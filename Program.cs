/*
Một lớp Point trong hệ tọa độ Descartes 2 chiều gồm các thuộc tính: x, y. Một lớp Cluster chứa một list các Point.
1/ Xây dựng lớp Point.
2/ Bổ sung vào Point: ToString dạng A(x, y), distance - tính khoảng cách giữa 2 điểm theo Euclidean.
3/ Bổ sung vào lớp Cluster: ToString dạng { A(x, y), B(x, y), C(x, y)}.
4 / Bổ sung phương thức distance cho Cluster để tính khoảng cách giữa các cụm theo single linkage (theo khoảng cách nhỏ nhất giữa các cặp điểm của 2 cụm).
5/ Bổ sung operator + để hợp 2 Cluster.
6/ Cài đặt thuật toán hierarchical clustering để phân cụm (với single linkage).
            public List<Cluster> HierarchicalClustering()
7 / Triển khai kết quả trong hàm main.
*/

using System;
using System.Text;
using System.Collections.Generic;

namespace Lab10_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Point> points = new List<Point>();
            points.Add(new Point("A", 1, 5));
            points.Add(new Point("B", 2, 2));
            points.Add(new Point("C", 6, 4));
            points.Add(new Point("D", 1, 4));
            points.Add(new Point("E", 3, 8));
            points.Add(new Point("F", 9, 2));

            Console.WriteLine("Các điểm ban đầu:");
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine(points[i]);
            }

            Console.WriteLine("\nKhoảng cách giữa " + points[0] + " và " + points[2] + " = " + points[0].Distance(points[2]));
            Console.WriteLine("\nKhoảng cách giữa " + points[3] + " và " + points[5] + " = " + points[3].Distance(points[5]));

            Console.WriteLine("\n--- Bắt đầu phân cụm ---");
            List<Cluster> result = Hierarchical.HierarchicalClustering(points);

            Console.WriteLine("\nKết quả cuối cùng:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].ToString());
            }
            Console.ReadLine();
        }
    }
}