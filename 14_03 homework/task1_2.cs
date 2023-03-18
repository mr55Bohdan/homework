using System;

namespace exeption_v4
{
    class Program
    {
        static double division(double a, double b)
        {
            if (b == 0)
            { throw new DivideByZeroException("Division by zero is not allowed"); }
            return a / b;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = division(a, b);
                Console.WriteLine($"division a/b={c}");
            }
            catch (DivideByZeroException ex) { Console.WriteLine("Error {0}", ex.Message); }
            catch (FormatException ex) { Console.WriteLine("Error {0}", ex.Message); }


        }

    }
}
