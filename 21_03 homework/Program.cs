using System;
using System.Collections.Generic;

namespace AbstractClassV3
{
    
    abstract class Shape : IComparable<Shape>
    {
        //fild
        private string name;
        public string Name
        {
            get => name; set => name = value;
        }
        protected Shape(string name)
        {
            Name = name;
        }
        
        public abstract double Perimeter();
        
        public abstract double Area();
        public abstract int CompareTo(Shape other);
    }
    
    class Square : Shape
    {
        public double Side;
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
               
        public override double Perimeter() { return (4 * Side); }
        public override double Area() 
        {
            return (Side* Side); 
        }
        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
    class Circle : Shape
    {

        public double Radius;

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }


        public override double Perimeter() 
        {
            return (2 *  Math.PI * Radius); 
        }
        public override double Area() 
        { 
            return (Math.PI* Radius * Radius); 
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

            for (int i = 0; i < 3; i++)
            {
                string shape = Console.ReadLine();
                if (shape.StartsWith("circle"))
                {
                    Console.WriteLine("radius");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shape1.Add(item: new Circle(name: shape, radius));
                }
                else
                {
                    Console.WriteLine("side");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shape1.Add(item: new Square(name: shape, side));
                }
            }
            foreach (var shape in shape1)
            {
               Console.WriteLine($"Shape {shape.Name} Area {shape.Area()} Perimeter {shape.Perimeter()}");
            }
            Console.WriteLine("sorted by area");
            shape1.Sort();
            
            foreach (var shape in shape1)
            {
                Console.WriteLine($"Shape {shape.Name} Area {shape.Area()} Perimeter {shape.Perimeter()}");
            }
            Shape maxShape;
            maxShape = shape1[0];
            foreach(var shape in shape1)
            {
                if (shape.Perimeter() > maxShape.Perimeter()) { maxShape = shape; }
            }
            Console.Write($"maxShape {maxShape.Name}  Perimeter {maxShape.Perimeter()}");
        }
    }
}
