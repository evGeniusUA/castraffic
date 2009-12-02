using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;

namespace TrafficSim
{
    public class Road
    {
        #region Properties
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

        private List<List<double>> positions;
        public String MatlabPositions
        {
            get
            {
                StringBuilder sb = new StringBuilder((int)this.positions.Count);
                sb.Append("% Positions as Function of time. Each row corresponds to a timestep.\n");
                sb.Append("Positions=[");
                foreach (List<double> timeStep in this.positions)
                {
                    foreach (double pos in timeStep)
                    {
                        sb.Append(pos.ToString("F4", culture));
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
                sb.Append("% Velocities as Function of time. Each row corresponds to a timestep.\n");
                sb.Append("Velocity=[");
                foreach (List<double> timeStep in this.velocities)
                {
                    foreach (double vel in timeStep)
                    {
                        sb.Append(vel.ToString("F4", culture));
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
                String s = "Time=linspace(0.0,";
                s += this.CurrentSimulationTime.ToString("F4", culture);
                s += ",";
                s += this.TimeStepSize.ToString("F4", culture);
                s += ");";
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
                s += " Time: " + System.DateTime.Now.ToShortTimeString() + "\n";

                s += "% RoadRadius (m) = " + this.RoadRadius.ToString("F2", culture) + "\n";
                s += "% RoadLength (m) = " + (this.RoadRadius * 2 * Math.PI).ToString("F2", culture) + "\n";
                s += "% TimeStep (s) = " + this.TimeStepSize.ToString("F2", culture) + "\n";
                s += "% RunTime (s) = " + this.CurrentSimulationTime.ToString("F2", culture) + "\n";
                s += "% SpeedLimit (km/h) = " + this.DesiredVelocityKmH.ToString("F2", culture) + "\n";
                s += "% NumberOFVehicles = " + this.NumberOfVehicles.ToString();
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
            this.desiredVelocity = maxV;
        }

        public Road() : this (500 / (2 * Math.PI), 3.5, 0.05, 0.0, 100/3.6)
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
                Car newVehicle = new Car(this, 1.0 + (r.NextDouble() - 0.5), 2.0, r.NextDouble());
                newVehicle.Position = new Radian(i * 2 * Math.PI / numberOfVehicles);
                this.AddVehicle(newVehicle);
            }

        }

        public void Iterate()
        {
            // call iterate for all vehicles (calculates new positions)
            Debug.Assert(this.NumberOfVehicles > 1, "No vehicles to iterate");
            List<double> pos = new List<double>(); //For exporting data to Matlab
            List<double> vel = new List<double>(); //For exporting data to Matlab

            foreach (Vehicle v in this.Vehicles)
            {
                v.Iterate(this.TimeStepSize);
                pos.Add(v.Position.Rad);
                vel.Add(v.Velocity);
                Debug.Assert(v.Position.Rad >= 0 && v.Position.Rad <= Math.PI * 2, "Radian error:", v.Position.Rad.ToString());
            }

            this.positions.Add(pos);
            this.velocities.Add(vel);
            this.currentSimulationTime += this.TimeStepSize;
        }
    }
}
