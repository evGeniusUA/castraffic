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
                throw new System.NotImplementedException();
            }
            set
            {
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

        public void Iterate(float timeStepSize)
        {
            throw new System.NotImplementedException();
            // Use Integrator.integrat(...) to get new position / speed
        }
    }
}
