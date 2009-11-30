using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Car : Vehicle
    {
        public Car(Road road) : base(road)
        {
            this.Length = 5.0;
            this.Width = 1.8;
        }
    }
}
