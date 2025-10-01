using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_OOP
{
    public class Hierarchical
    {
        public static List<Cluster> HierarchicalClustering(List<Point> points)
        {
            List<Cluster> clusters = new List<Cluster>();
            for (int i = 0; i < points.Count; i++)
            {
                clusters.Add(new Cluster(points[i]));
            }

            while (clusters.Count > 1)
            {
                double minDist = double.MaxValue;
                int idx1 = -1;
                int idx2 = -1;

                // tìm 2 cụm gần nhất
                for (int i = 0; i < clusters.Count; i++)
                {
                    for (int j = i + 1; j < clusters.Count; j++)
                    {
                        double d = clusters[i].Distance(clusters[j]);
                        if (d < minDist)
                        {
                            minDist = d;
                            idx1 = i;
                            idx2 = j;
                        }
                    }
                }

                // gộp cụm
                Cluster merged = clusters[idx1] + clusters[idx2];

                Console.WriteLine("Gộp " + clusters[idx1] + " và " + clusters[idx2] + "  (khoảng cách = " + minDist + ") \n => " + merged );


                // xóa cụm cũ, thêm cụm mới
                if (idx1 > idx2)
                {
                    clusters.RemoveAt(idx1);
                    clusters.RemoveAt(idx2);
                }
                else
                {
                    clusters.RemoveAt(idx2);
                    clusters.RemoveAt(idx1);
                }
                clusters.Add(merged);

                Console.WriteLine("Số cụm hiện tại: " + clusters.Count);
                for (int k = 0; k < clusters.Count; k++)
                {
                    Console.WriteLine("  Cụm " + (k + 1) + ": " + clusters[k]);
                }
                Console.WriteLine();
            }

            return clusters;
        }
    }


}
