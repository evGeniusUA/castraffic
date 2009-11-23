using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Vehicle
    {
        public double Position
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

        public void Iterate(float timeStepSize)
        {
            throw new System.NotImplementedException();
            // Use Integrator.integrat(...) to get new position / speed
        }
    }
}
