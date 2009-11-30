using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Car : Vehicle
    {
        public Car(Road road, Radian initialPosition) : base(road, initialPosition)
        {
        }
    }
}
