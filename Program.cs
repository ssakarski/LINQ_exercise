using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tod",180,70,Gender.Male),
                new Person("John",170,88,Gender.Male),
                new Person("Anna",150,48,Gender.Female),
                new Person("Kyle",164,77,Gender.Male),
                new Person("Anna",164,77,Gender.Male),
                new Person("Maria",16,55,Gender.Female),
                new Person("John",160,55,Gender.Male),
            };

            var selectedPeople = from person in people
                                 where person.Name.Length > 1
                                 orderby person.Name,person.Weight
                                 select person;
            foreach (var item in selectedPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Weight}kg");
            }



            //string sentence = "I love cats";
            //string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            //int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 13, 653, 3, 4, 5, 6, 7 };

            //var getTheNumbers = from number in numbers
            //                    where number <=4
            //                    orderby number descending
            //                    select number;

            //var catsWithA = from cat in catNames
            //                where cat.Contains('a') && cat.Length<5
            //                select cat;

            //Console.WriteLine(string.Join(", ", getTheNumbers));
            //Console.WriteLine(string.Join(", ", catsWithA));
        }
    }

    internal class Person
    {
        private string name;
        private int height;
        private int weight;

        private Gender gender;

        public string Name
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

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public Gender Gender { get; set; }

        public Person(string name, int height, int weight, Gender gender)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Gender = gender;
        }
    }
    internal enum Gender
    {
        Male,
        Female
    }
}
