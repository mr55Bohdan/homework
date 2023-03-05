using System;

namespace homework1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int[] arr2 = new int[5];
            int s=0,d=1;
            
            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"Enter namber [{i}]=");
            int a= Convert.ToInt32(Console.ReadLine());
                arr[i] = a;
             }
            for (int k = 0, j = 5; k < 5 && j < 10; k++,j++)
            {                 
                Console.Write($"Enter namber [{j}]=");
                int a2 = Convert.ToInt32(Console.ReadLine());
                arr2[k] = a2;
                
            }
            int oznaka=0;
            for (int ii = 0; ii < 5; ii++)
            {
                if (arr[ii] >= 0) { s += arr[ii]; } else { oznaka = 1; } }

            /* 
             { 
                 for (int jj = 5; jj < 10; jj++)
                  dd= arr2[jj]; d *= dd;
             }*/
            if (oznaka == 1) { 
                foreach (int x in arr2)
            { d *= x; }
            }
            if (oznaka == 0) { Console.WriteLine($"sum={s};"); } else { Console.WriteLine($"product={d}."); }

            
        }
    }
}
