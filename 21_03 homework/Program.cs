using System;
using System.Collections.Generic;

namespace abstractKlassV2
{
    public abstract class Shape
    {
        private string name;
        public string Name
        { 
            get=>name; set=> name= value; 
        }
        protected Shape(string name)
        { 
            Name = name;
        }
        public abstract double Area();

        public abstract double Perimeter();
        public abstract int CompareTo(Shape other);
     }
    public class Circle: Shape
    { 
        private double radius;
    public double Radius 
        {
            get => radius; set => radius = value;
        }
        public Circle (string name,double radius):base (name)
        { 
            Radius = radius; 
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
    public class Square : Shape
    { 
        private double side;
        public double Side
        {
            get => side; set => side = value;
        }
        public Square (string name, double side):base(name)
            {
            Side = side;
            }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape1 = new List<Shape>();
            for(int i=0;i<10;i++)
            { 
            Console.WriteLine("Enter circle or square");
            string shape=Console.ReadLine();
            if(shape.StartsWith("circle"))
            { 
            Console.WriteLine("radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                shape1.Add(item: new Circle(name:shape,radius));
            }
            else
            { 
            Console.WriteLine("side");
                double side= Convert.ToDouble(Console.ReadLine());
                shape1.Add(item: new Circle(name: shape, side));
            }
            }
            foreach(var shape in shape1)
            { 
                Console.WriteLine($"Shape {shape.Name} Area {shape.Area()} Perimeter {shape.Perimeter()}"); 
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
