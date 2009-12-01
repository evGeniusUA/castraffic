using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Car : Vehicle
    {
        public Car(Road road) : base(road)
        {
            this.length = 5.0;
            this.width = 1.8;
        }
    }
}
