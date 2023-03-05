using System;

namespace homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {float n1,n2,n3;
            n1 = (float)Convert.ToDouble(Console.ReadLine());
            n2 = (float)Convert.ToDouble(Console.ReadLine());
            n3 = (float)Convert.ToDouble(Console.ReadLine());

            if (n1 >= -5 && n1 <= 5 && n2 >= -5 && n2 <= 5 && n3 >= -5 && n3 <= 5)
                Console.WriteLine("Yes. They are all in the range [-5.5]");
            else
                Console.WriteLine("No. They arent in the range [-5.5]");
        }
    }
}
