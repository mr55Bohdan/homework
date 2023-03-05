using System;

namespace Homework1_4
{
    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString() { return string.Format($"({name},{mark},{age})", name, mark,age) ;}
        }
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.name = "Alabama";
            myDog.mark = "Doberman";
            myDog.age = 7;
            Console.Write(myDog);
           // Console.ReadLine();
        }
        
    }
}
