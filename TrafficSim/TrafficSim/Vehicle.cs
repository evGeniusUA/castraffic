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

        public float Speed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public float Acceleration
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

        public void Iterate(float timeStepSize)
        {
            double distanceToMove = 0.0;
            
            throw new System.NotImplementedException();
            // do stuff with dynamics, behaviour ...
            // Use Integrator.integrat(...) to get new position / speed
            // Set new pos with:
            // this.MoveToNewPos(distanceToMove);
        }
    }
}
