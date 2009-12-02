using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Car : Vehicle
    {
        public static readonly double CAR_LENGTH = 5.0;
        public static readonly double CAR_WIDTH = 1.8;

        public Car(Road road, double maxAcc, double maxBrake, double drv) : base(road, maxAcc, maxBrake, drv)
        {
            this.length = CAR_LENGTH;
            this.width = CAR_WIDTH;
        }
    }
}
