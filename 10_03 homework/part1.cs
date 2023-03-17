using System;
using System.Collections;
using System.Collections.Generic;

namespace interface1
{
    /***************************interface IDeveloper(begin)*************/
    interface IDeveloper:IComparable<IDeveloper>
    {
        void Create();
        void Destroy();
        string Tool { get;set; }
        
       public virtual string ToString() { return "developer" + Tool; }
    }
    /***************************interface IDeveloper(end);*************/
    
    /***************************class Programmer(begin)***************/
    class Programmer : IDeveloper
    {
        private string language;
        public string Tool { get { return language; } set{ language = value;  } }

        public void Create() { Console.WriteLine("Created a programmer {0}",  language); }
        public void Destroy() { Console.WriteLine("Remove the programmer {0}", language); }

        public int CompareTo(IDeveloper other)
        { return this.Tool.Length.CompareTo(other.Tool.Length); }
        public override string ToString() { return "developer " + Tool; }
    }
    /***************************class Programmer(end;)***************/

    /***************************class Builder (begin)***************/
    class Builder : IDeveloper
    { private string tool;
        public string Tool { get { return tool; } set { tool = value; } }
        public void Create() { Console.WriteLine("Created is Builder {0}", tool); }
        public void Destroy() { Console.WriteLine("Remove the Builder {0}", tool); }

        public int CompareTo(IDeveloper other)
        { return this.Tool.Length.CompareTo(other.Tool.Length); }

        public override string ToString() { return "developer " + Tool; }

    }
    /***************************class Builder (end;)***************/
    class Program
    {
        static void Main(string[] args)
        {   List<IDeveloper> employee = new List<IDeveloper>();
            employee.Add(new Programmer {Tool= "Pascal" });
            employee.Add(new Programmer { Tool = "C" });
            employee.Add(new Builder  { Tool = "C++" });
            employee.Add(new Builder { Tool = "C#" });


            foreach (IDeveloper e in employee)
            {
                e.Create();
                e.Destroy();
            }
            Console.WriteLine("Before");
            foreach (IDeveloper e in employee)
            { Console.WriteLine(e); }

           Console.WriteLine("After ");
            employee.Sort();
            foreach (IDeveloper e in employee)
            { Console.WriteLine(e); }

        }
    }
}
