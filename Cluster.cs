using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_OOP
{
    public class Cluster
    {
        private List<Point> points;

        public Cluster()
        {
            points = new List<Point>();
        }

        public Cluster(Point p)
        {
            points = new List<Point>();
            points.Add(p);
        }

        public List<Point> Points { get { return points; } }

        public override string ToString()
        {
            string s = "{";
            for (int i = 0; i < points.Count; i++)
            {
                s += points[i].ToString();
                if (i < points.Count - 1) s += ", ";
            }
            s += "}";
            return s;
        }

        public double Distance(Cluster other)
        {
            double minDist = double.MaxValue;
            for (int i = 0; i < this.points.Count; i++)
            {
                for (int j = 0; j < other.points.Count; j++)
                {
                    double d = this.points[i].Distance(other.points[j]);
                    if (d < minDist)
                    {
                        minDist = d;
                    }
                }
            }
            return minDist;
        }

        public static Cluster operator +(Cluster c1, Cluster c2)
        {
            Cluster merged = new Cluster();
            foreach (Point p in c1.points)
            {
                merged.Points.Add(p);
            }
            foreach (Point p in c2.points)
            {
                merged.Points.Add(p);
            }
            return merged;
        }
    }
}
