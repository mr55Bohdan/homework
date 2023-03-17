using System;
using System.Collections.Generic;

namespace dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> Person = new Dictionary<uint, string>() ;
            //Person.Add=Console.ReadLine();
            uint key_read = 0;string val_read;
            for (int i = 0; i < 7; i ++)
            {
                Console.Write("Enter ID and press enter ");
                key_read = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter Value and press enter ");
                val_read = Console.ReadLine();

                Person.Add(key_read, val_read);
            }


            /*
            Person.Add (1,"Baron");
            Person.Add(2, "Daria");
            Person.Add(3, "Maxs");
            Person.Add(4, "Gek");
            Person.Add(5, "Gon");
            Person.Add(6, "Anna");
            Person.Add(7, "Julia");
            */
            Console.Write("Find ID and press enter ");
            uint etalon = Convert.ToUInt32(Console.ReadLine()); ;
            bool oznaka = false;
            foreach (KeyValuePair<uint, string> kvp in Person)
            { if (etalon == kvp.Key)
                { Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value); oznaka = true; }
            else
                {; }
            }

            if (oznaka == false) Console.WriteLine("ID not found");
            //Console.WriteLine("Hello World!");
        }
    }
}
