using System;

namespace excption_v2
{
    class Program
    {
        static int division(int a, int b)
        { if (b == 0) 
            { throw new DivideByZeroException("Division by zero is not allowed"); }
            return a / b; }
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine ("Enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c=division(a, b);
                Console.WriteLine($"division a/b={c}"); }
            catch (DivideByZeroException ex) {Console.WriteLine("Error {0}", ex.Message) ; }
            catch (FormatException ex) { Console.WriteLine("Error {0}", ex.Message); }


        }
    }
}
