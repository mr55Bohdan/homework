using System;
using System.Drawing;

namespace hw10
{
    
        public struct Point
        {
            public double x, y;

            public override string ToString()
            {
                return "(" + this.x.ToString() + ";" + this.y.ToString() + ")";
            }
            public class Triangle
            {
                private Point p1, p2, p3;
                public Triangle(Point a, Point b, Point c)
                {
                    this.p1 = a;
                    this.p2 = b;
                    this.p3 = c;
                }

                

                public static double Distance(Point a, Point b)
                {
                    return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
                }
                public double Perimeter()
                {
                    return Distance(p1, p2) + Distance(p2, p3) + Distance(p3, p1);
                }
                /*public void square()
                {

                }*/
                public void Print()
                {
                    Console.WriteLine(p1 + " " + p2 + " " + p3);
                }
            }

            static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
        }
    }
}
