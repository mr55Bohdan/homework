using System;

namespace homework1_2
{
    class Program
    {
        static void count(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("January 31 day");
                    break;
                case 2:
                    Console.WriteLine("February 28 or 29 day");
                    break;
                case 3:
                    Console.WriteLine("March 31 day");
                    break;
                case 4:
                    Console.WriteLine("April 30 day");
                    break;
                case 5:
                    Console.WriteLine("May 31 day");
                    break;
                case 6:
                    Console.WriteLine("June 30 day");
                    break;
                case 7:
                    Console.WriteLine("July 31 day");
                    break;
                case 8:
                    Console.WriteLine("August 31 day");
                    break;
                case 9:
                    Console.WriteLine("September 30 day");
                    break;
                case 10:
                    Console.WriteLine("October 31 day");
                    break;
                case 11:
                    Console.WriteLine("November 30 day");
                    break;
                case 12:
                    Console.WriteLine("December 31 day");
                    break;

            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter month namber");
            int m=Convert.ToInt32(Console.ReadLine());
            count(m);
        }
    }
}
