using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Vehicle
    {
        #region Properties
        public Radian Position { get; set; } //For circular road in radians
        Queue<double> historyAcceleration; //FIFO-buffer with reactiontime

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
       
        protected double maxAcceleration = 0.6;
        public double MaxAcceleration
        {
            get
            {
                return this.maxAcceleration;
            }
            set
            {
            }
        }
        
        protected double maxBrake = 0.9;
        public double MaxBrake
        {
            get
            {
                return this.maxBrake;
            }
            set
            {
            }
        }

        protected double driver = 0.0;
        public double Driver
        {
            get
            {
                return this.driver;
            }
            set
            {
            }
        }
        #endregion

        // Constructor - add needed arguments
        // After constructing Vehicle object, don't forget to add NextVehicle...
        // You also need to modify Car constructor and other classes extending this
        public Vehicle(Road road, double maxAcc, double maxBrake, double drv)
        {
            this.road = road;
            this.maxAcceleration = maxAcc;
            this.maxBrake = maxBrake;
            this.driver = drv;
            this.velocity = this.Road.DesiredVelocity;
            this.historyAcceleration = new Queue<double>();
            for(int i = 0; i <1/this.Road.TimeStepSize; i++)
                historyAcceleration.Enqueue(0);
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
            double delta = 2;   //Constant between 1-5, "behaviour of driver"
            double a = this.MaxAcceleration; //Maximum acceleration
            double b = this.MaxBrake; //Maximum brake
            double s0 = 1; //Minimum gap
            double T = 0.5 + this.Driver; //Time headway
            double deltaV = this.Velocity - this.NextVehicle.Velocity + (this.Velocity - this.NextVehicle.Velocity) * 2 * (this.Driver - 0.5); //Difference in velocity
                    
            double sa = DistanceToNextVehicle() - this.Length; //Gap = distance to vehicle in front, bumper to bumper
            double sStar = s0+Math.Max(this.Velocity*T+this.Velocity*deltaV/(2*Math.Sqrt(a*b)),0); //Effective desired distance

            historyAcceleration.Enqueue(a * (1 - Math.Pow(this.Velocity / v0, delta) - Math.Pow(sStar / sa, 2))); //Update acceleration

            this.acceleration = historyAcceleration.Dequeue();
            this.velocity += this.Acceleration * timeStepSize; //Update velocity
            this.velocity = Math.Max(this.Velocity, 0);
            this.MoveToNewPos(this.Velocity * timeStepSize+ (1/2) * this.Acceleration * Math.Pow(timeStepSize,2)); //Update movement
        }
    }
}
