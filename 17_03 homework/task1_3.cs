using System;

namespace exeption_v3
{
    class Program
    {
        static int ReadNumber(int start, int end) 
        {                 
         
            if (start<end||start>100)
            { throw new Exception("numbers is invalid"); }else
            return 0;
        }
        static void Main(string[] args)
        {
            try
            {
                int y = 1;

                for (int i = 1; i < 11; i++) { 

                Console.Write($"Enter {i} number= ");
                int x = Convert.ToInt32(Console.ReadLine());
                    
                ReadNumber(x, y);
                    y= x;
                                 
                }

            }
            catch (Exception ex) { Console.WriteLine($"Error {ex.Message}"); }
           }
        }
    }

