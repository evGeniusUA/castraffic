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

        public double TimeStepSize
        {
            get
            {
                return this.TimeStepSize;
            }
            set
            {
            }
        }

        public double CurrentSimulationTime
        {
            get
            {
                return this.CurrentSimulationTime;
            }
            set
            {
            }
        }

        public Road(double radius, double timeStepSize, double startingTime)
        {
            this.RoadRadius = radius;
            this.TimeStepSize = timeStepSize;
            this.CurrentSimulationTime = startingTime;
        }

        private void AddVehicle(Vehicle vehicle)
        {
            vehicle.NextVehicle = this.Vehicles.Last.Value;
            this.Vehicles.First.Value.NextVehicle = vehicle;
            this.Vehicles.AddLast(vehicle);
        }

        public void Populate(int numberOfVehicles)
        {
            // Toy function which just adds cars at evenly distributed around the road

            for (int i = 0; i < numberOfVehicles; i++)
            {
                Car newVehicle = new Car(this);
                newVehicle.Position = new Radian(i * 2 * Math.PI / numberOfVehicles);
                this.AddVehicle(newVehicle);
            }

        }

        public void Iterate()
        {
            // call iterate for all vehicles (calculates new positions)
            foreach (Vehicle v in this.Vehicles)
            {
                v.Iterate(this.TimeStepSize);
            }
            this.CurrentSimulationTime += this.TimeStepSize;
        }

    }
}
