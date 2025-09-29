using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_OOP
{
    public class Point
    {
        public string Label;  
        public double X;
        public double Y;

        public Point(string label, double x, double y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return Label + "(" + X + ", " + Y + ")";
        }

        public double Distance(Point other)
        {
            double dx = this.X - other.X;
            double dy = this.Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

}
