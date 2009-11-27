using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Road
    {
        public LinkedList<Vehicle> Vehicles
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double RoadRadius
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public float TimeStepSize
        {
            get
            {
                return this.TimeStepSize;
            }
            set
            {
            }
        }

        public void Iterate()
        {
            // call iterate for all vehicles (calculates new positions)
            foreach (Vehicle v in this.Vehicles)
            {
                v.Iterate(this.TimeStepSize);
            }
        }

        public double DistanceBetweenVehicles(Vehicle a, Vehicle b)
        {
            Radian alpha = b.Position - a.Position;
            return alpha.ToDistance(this.RoadRadius);
        }
    }
}
