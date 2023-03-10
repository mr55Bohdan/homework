using System;

namespace ConsoleApp2
{
    class Program
    {public class Person
        { private string name;
            private DateTime birthday;
            //*******************************************//
            public string Name
            { get
                { return name; }
                set { name = value; }
                //********************************************//
                }
            public DateTime BirthDay
            { get
                { return birthday; }
                set { birthday = value; }
            }
            //*********************************************************//
            public Person() { name = " "; birthday = DateTime.Today; }
            public Person(string n, DateTime yy) { name = n; birthday = yy; }

            //*************************************************************//
            public int age(DateTime date1, DateTime date2)
            { int t = date2.Year-date1.Year;
                /* TimeSpan t = date2.Subtract(date1);
                int x = int.Parse(t.ToString());
                return x;*/
                return t;}
            
            //***********************************************************//
            public void GetInfo() { Console.WriteLine($"name {name}, birthday {birthday}"); }
            //************************************************************//
            public void ChangeName(string n)
            { Name = n; }
            }
        static void Main(string[] args)
        {
            
            Person a1 = new Person();
            a1.Name = "Gek";
            Console.WriteLine($"enter birthday {a1.Name} yyyy,mm,dd");
            a1.BirthDay = Convert.ToDateTime(Console.ReadLine ());
            a1.GetInfo();
            var today = DateTime.Today;
            int y;
            y = a1.age(a1.BirthDay, today);
            Console.WriteLine($"have person 1 {y}  years");
            
            a1.ChangeName("Bohdan");
            a1.GetInfo();
            /*****************************************************************************/
            Person a2 = new Person();
            a2.Name = "Marta";
            Console.WriteLine($"enter birthday {a2.Name} yyyy,mm,dd");
            a2.BirthDay = Convert.ToDateTime(Console.ReadLine());
            a2.GetInfo();
           // var today = DateTime.Today;
            int y2;
            y2 = a2.age(a2.BirthDay, today);
            Console.WriteLine($"have person 2 {y2}  years");
            a2.ChangeName("Sofiya");
            a2.GetInfo();
            /***************************************************************************/
            Person a3 = new Person();
            a3.Name = "Gon";
            Console.WriteLine($"enter birthday {a3.Name} yyyy,mm,dd");
            a3.BirthDay = Convert.ToDateTime(Console.ReadLine());
            a3.GetInfo();
            // var today = DateTime.Today;
            int y3;
            y3 = a3.age(a3.BirthDay, today);
            Console.WriteLine($"have person 3 {y3}  years");
            a3.ChangeName("Solomon");
            a3.GetInfo();
            /***************************************************************************/
            Person a4 = new Person();
            a4.Name = "Anna";
            Console.WriteLine($"enter birthday {a4.Name} yyyy,mm,dd");
            a4.BirthDay = Convert.ToDateTime(Console.ReadLine());
            a4.GetInfo();
            // var today = DateTime.Today;
            int y4;
            y4 = a4.age(a4.BirthDay, today);
            Console.WriteLine($"have person 4 {y4}  years");
            a4.ChangeName("Mary");
            a4.GetInfo();
            /***************************************************************************/
            Person a5 = new Person();
            a5.Name = "Joseph";
            Console.WriteLine($"enter birthday {a5.Name} yyyy,mm,dd");
            a5.BirthDay = Convert.ToDateTime(Console.ReadLine());
            a5.GetInfo();
            // var today = DateTime.Today;
            int y5;
            y5 = a5.age(a5.BirthDay, today);
            Console.WriteLine($"have person 5 {y5}  years");
            a5.ChangeName("Barack");
            a5.GetInfo();



        }
    }
}
