using System;

namespace homework1_3
{
   
    
    class Program
    {
        enum HTTPError
        {
            Error_a = 400,
            Error_b = 401,
            Error_c = 402
        }
        static void show(int a)
        { switch (a)
            { case 400:
                    Console.WriteLine(HTTPError.Error_a);
                        break;
                case 401:
                    Console.WriteLine(HTTPError.Error_b);
                        break;
                case 402:
                    Console.WriteLine(HTTPError.Error_c);
                    break;
            } }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 400 to 402 ");
            int n = Convert.ToInt32(Console.ReadLine());

            show(n);
            
            

            
        }
    }

}