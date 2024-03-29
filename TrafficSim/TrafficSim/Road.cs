﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;

namespace TrafficSim
{
    public class Road
    {
        #region Properties
        private int counter;
        private CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

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

        private double desiredVelocity;
        public double DesiredVelocity
        {
            get
            {
                return this.desiredVelocity;
            }
            set
            {
            }
        }
        
        public double DesiredVelocityKmH
        {
            get
            {
                return this.desiredVelocity * 3.6;
            }
            set
            {
            }
        }

        public double AverageVelocityKmH
        {
            get
            {
                double sum = 0.0;
                foreach (Vehicle v in this.Vehicles)
                {
                    sum += v.Velocity;
                }
                return sum * 3.6 / this.Vehicles.Count;
            }
            set
            {
            }
        }

        public double TrafficDensityCarKm
        {
            get
            {
                return this.Vehicles.Count / (this.RoadRadius * 2 * Math.PI / 1000);
            }
            set
            {
            }
        }

        public double TrafficFlowCarH
        {
            get
            {
                return this.Vehicles.Count * this.AverageVelocityKmH / (this.RoadRadius * 2 * Math.PI / 1000);
            }
            set
            {
            }
        }

        private double startPositionMaxDeviation;

        private List<List<double>> positions;
        public String MatlabPositions
        {
            get
            {
                StringBuilder sb = new StringBuilder((int)this.positions.Count);
                sb.Append("% Positions (m) as Function of time. Each row corresponds to a timestep.\n");
                sb.Append("Positions=[");
                foreach (List<double> timeStep in this.positions)
                {
                    foreach (double pos in timeStep)
                    {
                        sb.Append((pos*this.RoadRadius).ToString("F4", culture));
                        sb.Append(" ");
                    }
                    sb.Append("; ");
                }
                sb.Append("];");
                return sb.ToString();
            }
            set
            {
            }
        }

        private List<List<double>> velocities;
        public String MatlabVelocities
        {
            get
            {
                StringBuilder sb = new StringBuilder((int)this.velocities.Count);
                sb.Append("% Velocities (m/s) as Function of time. Each row corresponds to a timestep.\n");
                sb.Append("Velocity=[");
                foreach (List<double> timeStep in this.velocities)
                {
                    foreach (double vel in timeStep)
                    {
                        sb.Append((vel*3.6).ToString("F4", culture));
                        sb.Append(" ");
                    }
                    sb.Append("; ");
                }
                sb.Append("];");
                return sb.ToString();
            }
            set
            {
            }
        }


        private List<List<double>> accelerations;
        public String MatlabAccelerations
        {
            get
            {
                StringBuilder sb = new StringBuilder((int)this.accelerations.Count);
                sb.Append("% Accelerations (m/s) as Function of time. Each row corresponds to a timestep.\n");
                sb.Append("Acceleration=[");
                foreach (List<double> timeStep in this.accelerations)
                {
                    foreach (double acc in timeStep)
                    {
                        sb.Append((acc * 3.6).ToString("F4", culture));
                        sb.Append(" ");
                    }
                    sb.Append("; ");
                }
                sb.Append("];");
                return sb.ToString();
            }
            set
            {
            }
        }

        public String MatlabTime
        {
            get
            {
                String s = "Time=";
                s += this.TimeStepSize.ToString("F4", culture);
                s += ":";
                s += this.TimeStepSize.ToString("F4", culture);
                s += ":";
                s += this.CurrentSimulationTime.ToString("F4", culture);
                s += ";";
                return s;
            }
            set
            {
            }
        }

        public String MatlabSettings
        {
            get
            {
                String s = "%% Export from TrafficSim.";
                s += " Date: " + System.DateTime.Today.ToShortDateString();
                s += " Time: " + System.DateTime.Now.ToShortTimeString() + "\n\n";

                s += "% RoadRadius (m) = " + this.RoadRadius.ToString("F2", culture) + "\n";
                s += "% RoadLength (m) = " + (this.RoadRadius * 2 * Math.PI).ToString("F2", culture) + "\n";
                s += "% TimeStep (s) = " + this.TimeStepSize.ToString("F2", culture) + "\n";
                s += "% RunTime (s) = " + this.CurrentSimulationTime.ToString("F2", culture) + "\n";
                s += "% SpeedLimit (km/h) = " + this.DesiredVelocityKmH.ToString("F2", culture) + "\n\n";
                
                s += "% NumberOFVehicles = " + this.NumberOfVehicles.ToString() + "\n";
                s += "% Maximum deviation of start position (m) = " + this.startPositionMaxDeviation.ToString("F2", culture) + "\n";
                s += "% TimeHeadway (s) = " + Car.CAR_TIME_HEADWAY.ToString("F2", culture) + "\n";
                s += "% MaxAcceleration (m/(s^2)) = " + Car.CAR_MAX_ACCELERATION.ToString("F2", culture) + "\n";
                s += "% MaxBrake (m/(s^2)) = " + Car.CAR_MAX_BRAKE.ToString("F2", culture) + "\n";
                s += "% DriverReactionTime (s) = " + Car.CAR_DRIVER_REACTION_TIME.ToString("F2", culture) + "\n";
                s += "% AdaptionToNextNextVehicle () = " + Car.CAR_ADAPTION_TO_NEXT_NEXT_VEHICLE.ToString("F2", culture) + "\n\n";
                return s;
            }
            set
            {
            }
        }
        #endregion

        public Road(double radius, double width, double timeStepSize, double startingTime, double maxV)
        {
            this.roadRadius = radius;
            this.width = width;
            this.timeStepSize = timeStepSize;
            this.currentSimulationTime = startingTime;
            this.vehicles = new LinkedList<Vehicle>();
            this.positions = new List<List<double>>();
            this.velocities = new List<List<double>>();
            this.accelerations = new List<List<double>>();
            this.desiredVelocity = maxV;
            this.startPositionMaxDeviation = 1.0;
            this.counter = 0;
        }

        public Road() : this (800 / (2 * Math.PI), 3.5, 0.05, 0.0, 50/3.6)
        {
            // Standard parameters
        }

        private void AddVehicle(Vehicle vehicle)
        {
            if (this.Vehicles.Count == 0)
            {
                this.Vehicles.AddLast(vehicle);
            }
            else
            {
                vehicle.NextVehicle = this.Vehicles.First.Value;             
                this.Vehicles.Last.Value.NextVehicle = vehicle;                
                this.Vehicles.AddLast(vehicle);
            }
        }

        public void Populate(int numberOfVehicles)
        {
            Debug.Assert(numberOfVehicles > 1, "Number of Vehicles must be > 1");
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < numberOfVehicles; i++)
            {
                Car newVehicle = new Car(this);
                newVehicle.Position = new Radian((i * 2 * Math.PI / numberOfVehicles)) 
                                       + Radian.FromDistance(
                                            (r.NextDouble()) * this.startPositionMaxDeviation
                                            , this.RoadRadius);
                this.AddVehicle(newVehicle);
            }

        }

        public void Iterate()
        {
            // call iterate for all vehicles (calculates new positions)
            Debug.Assert(this.NumberOfVehicles > 1, "No vehicles to iterate");
            List<double> pos = new List<double>(); //For exporting data to Matlab
            List<double> vel = new List<double>(); //For exporting data to Matlab
            List<double> acc = new List<double>(); //For exporting data to Matlab
            
            foreach (Vehicle v in this.Vehicles)
            {
                v.Iterate(this.TimeStepSize);
            }
            int vehicleCounter = 0;
            foreach (Vehicle v in this.Vehicles)
            {
                v.UpdatePosAndVel();
                if(counter % 3 == 0)
                {
                    if (vehicleCounter == 0)
                    {
                        pos.Add(v.Position.Rad);
                        vel.Add(v.Velocity);
                        acc.Add(v.Acceleration);
                    }
                    vehicleCounter++;
            }
                //Debug.Assert(v.Position.Rad >= 0 && v.Position.Rad <= Math.PI * 2, "Radian error:", v.Position.Rad.ToString());
            }
            if (counter % 3 == 0)
            {
                this.positions.Add(pos);
                this.velocities.Add(vel);
                //this.accelerations.Add(acc);
            }
            counter++;
            this.currentSimulationTime += this.TimeStepSize;
        }
    }
}
