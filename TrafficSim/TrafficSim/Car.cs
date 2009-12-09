using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Car : Vehicle
    {
        // Car specifications:
        public static readonly double CAR_LENGTH = 5.0;
        public static readonly double CAR_WIDTH = 1.8;
        public static readonly double CAR_TIME_HEADWAY = 1.5;
        public static readonly double CAR_MAX_ACCELERATION = 0.73;
        public static readonly double CAR_MAX_BRAKE = 1.63;
        public static readonly double CAR_DRIVER_REACTION_TIME = 1.0;

        public Car(Road road) : base(road, CAR_MAX_ACCELERATION, CAR_MAX_BRAKE, CAR_TIME_HEADWAY, CAR_DRIVER_REACTION_TIME)
        {
            this.length = CAR_LENGTH;
            this.width = CAR_WIDTH;
        }
    }
}
