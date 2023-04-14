using System;
using System.Collections.Generic;

namespace hw11
{
    delegate void MyDel(int m);

    class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            if (MarkChange != null)
            {
                MarkChange(mark);
            }
        }

    }
    class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"new mark is added {mark}");
        }
    }
    class Accountancy
    {

        public void PayingFellowship(int r)
        {
            if (r >= 71)
                Console.WriteLine("student have a scholarship");
            else
                Console.WriteLine("student haven't a scholarship");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            int rating = 71;
            Student student1 = new Student { Name = "Petro", Marks = new List<int>() };
            Parent parent1 = new Parent();
            Accountancy accountancy1 = new Accountancy();
            student1.MarkChange += parent1.OnMarkChange;
            student1.AddMark(rating);
       
             accountancy1.PayingFellowship(rating);
            
        }
    }
}
