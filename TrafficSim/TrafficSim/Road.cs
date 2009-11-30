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
                return this.Vehicles;
            }
            set
            {
            }
        }

        public double RoadRadius
        {
            get
            {
                return this.RoadRadius;
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

        public Road(double radius, float timeStepSize)
        {
            this.RoadRadius = radius;
            this.TimeStepSize = timeStepSize;
        }

        public void Iterate()
        {
            // call iterate for all vehicles (calculates new positions)
            foreach (Vehicle v in this.Vehicles)
            {
                v.Iterate(this.TimeStepSize);
            }
        }
    }
}
