using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSim
{
    public class Radian
    {

        public double Rad { get; set; }

        public Radian(double r)
        {
            this.Rad = r;
        }

        public static Radian operator +(Radian a, Radian b)
        {
            return new Radian((a.Rad + b.Rad) % 2 * Math.PI);
        }
        
        public static Radian operator -(Radian a, Radian b)
        {
            return new Radian((a.Rad - b.Rad) % 2 * Math.PI);
        }

        public double ToDistance(double radius)
        {
            return this.Rad * radius;
        }

        public double ToDegrees()
        {
            return this.Rad * 180 / Math.PI;
        }

        public static Radian FromDistance(double distance, double radius)
        {
            return new Radian(distance/radius);
        }
    }
}
