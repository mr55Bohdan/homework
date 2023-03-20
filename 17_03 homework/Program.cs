using System;
using System.Collections.Generic;
using System.IO;


namespace file_v1
{  
    class Program
    {
        //  int CompareTo(string a, string b)
        //{return a.Length.CompareTo(b.Length); }

        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            //string[] parts;
            StreamReader reader = new StreamReader(@"C:\Users\USER\source\repos\file_v1\file.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] arr = line.Split(',');
                int i = 0;
                while (i < arr.Length)
                {
                    PhoneBook.Add(arr[i], arr[i + 1]);
                    i += 2;
                }

            }
            reader.Close();
            // foreach (var k in PhoneBook) { Console.WriteLine(k); }

            StreamWriter writer = new StreamWriter(@"C:\Users\USER\source\repos\file_v1\Phones.txt");
            {
                foreach (KeyValuePair<string, string> kvp in PhoneBook)
                {
                    writer.WriteLine(kvp.Key);
                }
            }
            writer.Close();



            Console.Write("Find name and press enter ");
            string etalon = Convert.ToString(Console.ReadLine());
            string etalon2; string str = "+3";
            int oznaka = 1,oznaka1=1;
            foreach (KeyValuePair<string, string> kvp in PhoneBook)
            {
                //if (etalon.Length == kvp.Value.Length)
                // {
                etalon2 = Convert.ToString(kvp.Value);
                oznaka = etalon.CompareTo(etalon2);
                if (oznaka == 0)
                {  Console.WriteLine("{0}  {1}", kvp.Key, kvp.Value);oznaka1 = 0; }
                else {; }
            }
            if (oznaka1 == 1) { Console.WriteLine("Name is missing"); } else {; }


            // foreach (string c in PhoneBook.Keys) { PhoneBook.Keys = str + c; }
            StreamWriter writer1 = new StreamWriter(@"C:\Users\USER\source\repos\file_v1\New.txt");
            {
                foreach (KeyValuePair<string, string> kvp in PhoneBook)
                {
                    writer1.WriteLine($"{str+kvp.Key},{kvp.Value} ");
                }
            }
            writer1.Close();
        }
        
    }
}
