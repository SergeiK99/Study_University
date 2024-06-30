using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    public class Zadanie2
    {
        public double[] z2(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException();
            double x1;
            double x2;
            double d = (b * b) - (4 * (a * c));
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);

                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (d == 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                return new double[] { x1 };
            }
            else
            {
                return new double[0];
            }
        }
    }
}
