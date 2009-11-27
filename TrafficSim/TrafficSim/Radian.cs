using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Radian
    {

        public double value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public Radian(double val)
        {
            this.value = val;
        }

        public static Radian operator +(Radian a, Radian b)
        {
            return new Radian((a.value + b.value) % 2 * Math.PI);
        }
        
        public static Radian operator -(Radian a, Radian b)
        {
            return new Radian((a.value - b.value) % 2 * Math.PI);
        }

        public double ToDistance(double radius)
        {
            return this.value * radius;
        }

        public static Radian FromDistance(double distance, double radius)
        {
            return new Radian(distance/radius);
        }
    }
}
