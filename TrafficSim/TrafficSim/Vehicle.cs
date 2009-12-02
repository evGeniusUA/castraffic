using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Vehicle
    {
        #region Properties
        public Radian Position { get; set; } //For circular road in radians

        protected double velocity;
        public double Velocity
        {
            get
            {
                return this.velocity;
            }
            set
            {
            }
        }

        protected double acceleration;
        public double Acceleration
        {
            get
            {
                return this.acceleration;
            }
            set
            {
            }
        }

        public Vehicle NextVehicle { get; set; }

        protected Road road;
        public Road Road
        {
            get
            {
                return this.road;
            }
            set
            {
            }
        }

        protected double width = 2.0;
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
            }
        }

        protected double length = 5.0;
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
            }
        }
        #endregion

        // Constructor - add needed arguments
        // After constructing Vehicle object, don't forget to add NextVehicle...
        // You also need to modify Car constructor and other classes extending this
        public Vehicle(Road road)
        {
            this.road = road;
        }

        public double DistanceToNextVehicle()
        {
            Radian alpha = this.NextVehicle.Position - this.Position;
            return alpha.ToDistance(this.Road.RoadRadius);
        }

        private void MoveToNewPos(double distanceToMove)
        {
            this.Position = this.Position + Radian.FromDistance(distanceToMove, this.Road.RoadRadius);
        }

        public void Iterate(double timeStepSize)
        {
            double v0 = this.road.DesiredVelocity;
            double delta = 4;   //Constant between 1-5, "behaviour of driver"
            double a = 3; //Maximum acceleration
            double b = 0.9; //Maximum brake
            double s0 = 2; //Minimum gap
            double T = 1.5; //Time headway
            double deltaV = this.Velocity - this.NextVehicle.Velocity; //Difference in velocity
                    
            double sa = DistanceToNextVehicle() - this.Length; //Gap = distance to vehicle in front, bumper to bumper
            double sStar = s0+Math.Max(this.Velocity*T+this.Velocity*deltaV/(2*Math.Sqrt(a*b)),0); //Effective desired distance

            this.acceleration = a * (1 - Math.Pow(this.Velocity / v0, delta) - Math.Pow(sStar / sa, 2)); //Update acceleration
            this.velocity += this.Acceleration * timeStepSize; //Update velocity
            this.MoveToNewPos(this.Velocity * timeStepSize); //Update movement
        }
    }
}
