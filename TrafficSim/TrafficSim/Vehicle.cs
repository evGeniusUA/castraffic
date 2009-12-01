using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Vehicle
    {
        public Radian Position  //For circular road in radians
        {
            get
            {
                return this.Position;
            }
            set
            {
                this.Position = value;
            }
        }

        public double Velocity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double Acceleration
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Vehicle NextVehicle
        {
            get
            {
                return this.NextVehicle;
            }
            set
            {
                this.NextVehicle = value;
            }
        }

        public Road Road
        {
            get
            {
                return this.Road;
            }
            set
            {
            }
        }

        public double Width
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double Length
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // Constructor - add needed arguments
        // After constructing Vehicle object, don't forget to add NextVehicle...
        // You also need to modify Car constructor and other classes extending this
        public Vehicle(Road road)
        {
            this.Road = road;
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
            double distanceToMove = 0.0;

            double v0 = 120;
            double delta = 4;   //Constant between 1-5, "behaviour of driver"
            double a = 0.6; //Maximum acceleration
            double b = 0.9; //Maximum brake
            double s0 = 2; //Minimum gap
            double T = 1.5; //Time headway
            double deltaV = this.Velocity - this.NextVehicle.Velocity; //Difference in velocity
                    
            double sa = DistanceToNextVehicle() - this.Length; //Gap = distance to vehicle in front, bumper to bumper
            double sStar = s0+Math.Max(this.Velocity*T+this.Velocity*deltaV/(2*Math.Sqrt(a*b)),0); //Effective desired distance

            this.Acceleration = a * (1 - Math.Pow(this.Velocity / v0, delta) - Math.Pow(sStar / sa, 2)); //Update acceleration
            this.Velocity = this.Acceleration * timeStepSize; //Update velocity
            distanceToMove = this.Velocity * timeStepSize; //Update movement

            throw new System.NotImplementedException();
            // do stuff with dynamics, behaviour ...
            // Use Integrator.integrat(...) to get new position / speed
            // Set new pos with:
            // this.MoveToNewPos(distanceToMove);
        }
    }
}
