﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TrafficSim
{
    public class Road
    {
        #region Properties
        
        private LinkedList<Vehicle> vehicles;
        public LinkedList<Vehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
            set
            {
            }
        }
        
        public int NumberOfVehicles
        {
            get
            {
                return this.vehicles.Count;
            }
            set
            {
            }
        }

        private double roadRadius;
        public double RoadRadius
        {
            get
            {
                return this.roadRadius;
            }
            set
            {
            }
        }

        private double width;
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

        private double timeStepSize;
        public double TimeStepSize
        {
            get
            {
                return this.timeStepSize;
            }
            set
            {
            }
        }

        private double currentSimulationTime;
        public double CurrentSimulationTime
        {
            get
            {
                return this.currentSimulationTime;
            }
            set
            {
            }
        }
        #endregion

        public Road(double radius, double width, double timeStepSize, double startingTime)
        {
            this.roadRadius = radius;
            this.width = width;
            this.timeStepSize = timeStepSize;
            this.currentSimulationTime = startingTime;
            this.vehicles = new LinkedList<Vehicle>();
        }

        private void AddVehicle(Vehicle vehicle)
        {
            if (this.Vehicles.Count == 0)
            {
                this.Vehicles.AddLast(vehicle);
            }
            else
            {
                vehicle.NextVehicle = this.Vehicles.Last.Value;
                this.Vehicles.First.Value.NextVehicle = vehicle;
                this.Vehicles.AddLast(vehicle);
            }
        }

        public void Populate(int numberOfVehicles)
        {
            Debug.Assert(numberOfVehicles > 1, "Number of Vehicles must be > 1");

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
                Debug.Assert(v.Position.Rad >= 0 && v.Position.Rad <= Math.PI * 2, "Radian error:", v.Position.Rad.ToString());
            }
            this.currentSimulationTime += this.TimeStepSize;
        }
    }
}
