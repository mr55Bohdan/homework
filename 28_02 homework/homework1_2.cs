using System;

namespace homework1_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            int max;
            int min;
            if (n1 < n2) { min = n1; max = n2; }
           else
           { max = n1; min = n2; }

            if (n3 < min) { min = n3; } else { if (n3 > max) { max = n3; } }

            
            Console.WriteLine($"max={max} ***** min={min}");
            


        }
    }
}
