using System;

namespace homework1_1
{
    class Program
    {       
        static void Main(string[] args)
        {
            int a=0, o=0, i=0, e=0;
            Console.WriteLine("enter text:");
            string str = Console.ReadLine();
            
           for (int J = 0; J < str.Length; J++)
           {if (str[J] == 'a') a += 1;
                if (str[J] == 'o') o += 1;
                if (str[J] == 'i') i += 1;
                if (str[J] == 'e') e += 1;
            }
              
          Console.WriteLine($"Count_a={a};count_o={o}; count_i={i}; count_e={e}.");
        }
    }
}
