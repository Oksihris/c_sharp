using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1
{
    public class Point : IPoint
    { 
        double X { get; set; } = 0.0;
        double Y { get; set; } = 0.0;
        double IPoint.X { get; set; } = 0.0;
        double IPoint.Y { get; set; } = 0.0;

       public Point()
        {
        }

        public Point(double x, double y)
        {
            X = x;
           Y = y;
        }
       
      

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   X == point.X &&
                  Y == point.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = -37582793;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return String.Format("Point ({X}, {Y})", X, Y);
        }


        double IPoint.CalculateDistance(IPoint point, IPoint point1)
        {
         
            return Math.Sqrt((point.X - point1.X) * (point.X - point1.X)
                         + (point.Y - point1.Y) * (point.Y - point1.Y));
        }

        string IPoint.Quadrans()
        {
            if (X > 0 && Y > 0)
            {
                return "First Quadran";
            }
            else if (X > 0 && Y < 0)
            {
                return "Fourth Quadran";
            }
            else if (X < 0 && Y > 0)
            {
                return "Second Quadran";
            }
            else if (X < 0 && Y > 0)
            {
                return "Third Quadran";
            }
            else
                return "On axle";
        }
    }
}
