/*
 * (7)
 * Визначити абстрактний клас «Тварина»(назва, рік народження),
 * похідні від нього типи «Кінь» (масть, порода) та «Осел» (вид, висота)
 * В текстовому файлі задано змішані дані про коней та віслюків. 
 * Зчитати ці дані у один масив і вивести у Файл1 відсортовані за роком народження всіх тварин.
 * У Файл2 вивести коней білої масті та віслюків висоти не більше 1,5 метра з вказанням їх кількості.  
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace final_v4
{    
    public abstract class Animal : IComparable<Animal>
    {
        protected string name;
        public abstract string Name
        {
            get;
            set;
        }
        private int birth_year;
        public int Birth_Year
        {
            get => birth_year; set => birth_year = value;
        }
        protected Animal(int birth_year)
        {
            Birth_Year = birth_year;
        }
        public abstract int CompareTo(Animal other);
    }
    //class Horse
    public class Horse : Animal
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string color;
        public string Color
        {
            get => color; set => color = value;
        }

        private string genus;
        public string Genus
        {
            get => genus; set => genus = value;
        }
        public Horse(string name, int birth_year, string color, string genus) : base(birth_year)
        {
            Color = color;
            Genus = genus;
            Name = name;
        }

        public override int CompareTo(Animal other)
        {
            return (Birth_Year).CompareTo(other.Birth_Year);
        }
    }
    public class Ass : Animal
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string kind;
        public string Kind
        {
            get => kind; set => kind = value;
        }
        private double height;
        public double Height
        {
            get => height; set => height = value;
        }
        public Ass(string name, int birth_year, string kind, double height) : base(birth_year)
        {
            Kind = kind;
            Height = height;
            Name = name;
        }
        public override int CompareTo(Animal other)
        {
            return Birth_Year.CompareTo(other.Birth_Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals_List = new List<Animal>();
            List<Horse> horses_List = new List<Horse>();
            List<Ass> asses_List = new List<Ass>();
            bool oznaka = false;
            string dir = @"C:\Users\USER\source\repos\final_v4";
            try
            {
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found: " + dirEx.Message); oznaka = true;
            }
            finally
            {
                if (oznaka == true)
                { System.Environment.Exit(1); }
                else
                {
                    StreamReader reader = new StreamReader(@"C:\Users\USER\source\repos\final_v4\file.txt");
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Do something with the line.
                        string[] parts = line.Split('*');
                        if (parts[0].StartsWith("Horse"))
                        {
                            Horse horse = new Horse(parts[0], Convert.ToInt32(parts[1]), parts[2], parts[3]);
                            animals_List.Add(horse);
                            horses_List.Add(horse);
                        }
                        else
                        {
                            Ass ass = new Ass(parts[0], Convert.ToInt32(parts[1]), parts[2], Convert.ToDouble(parts[3]));
                            animals_List.Add(ass);
                            asses_List.Add(ass);
                        }
                    }
                    reader.Close();
                    animals_List.Sort();
                    StreamWriter writer1 = new StreamWriter(@"C:\Users\USER\source\repos\final_v4\file1.txt");
                    {
                        foreach (var a in animals_List)
                        {
                            writer1.WriteLine($"{a.Name} birth_year {a.Birth_Year},");
                        }
                    }
                    writer1.Close();
                    int i = 0, j = 0;
                    StreamWriter writer2 = new StreamWriter(@"C:\Users\USER\source\repos\final_v4\file2.txt");
                    {
                        foreach (var h in horses_List)
                        {
                            if (h.Color.StartsWith("white"))
                            { writer2.WriteLine($"{h.Name},{h.Birth_Year},{h.Color},{h.Genus}"); i++; }
                        }
                        writer2.WriteLine("*****************************");
                        foreach (var a in asses_List)
                        {
                            if (a.Height < 1.5)
                            { writer2.WriteLine($"{a.Name},{a.Birth_Year},{a.Kind},{a.Height}"); j++; }
                        }
                    }
                    writer2.WriteLine("*****************************");
                    writer2.WriteLine($"number_Horse={i}, number_Ass={j}");
                    writer2.Close();
                    string jsonString;
                    StreamWriter writer3 = new StreamWriter(@"C:\Users\USER\source\repos\final_v4\json.txt");
                    foreach (var h in horses_List)
                    {
                        jsonString = JsonSerializer.Serialize(h);
                        writer3.WriteLine(jsonString);
                    }
                    writer3.Close();
                }
            }
        }
    }
}
