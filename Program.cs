using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>(){ 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 13, 653, 3, 4, 5, 6, 7 };
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd"};
            List<Warrior> war = new List<Warrior>()
            {
                new Warrior(){Height = 100},
                new Warrior(){Height = 80},
                new Warrior(){Height = 100},
                new Warrior(){Height = 70}
            };

            var oddNumbers = from n in numbers
                             where n % 2 == 1
                             select n;

            // doing the same but with lambda expression
            var oddNums = numbers.Where(n => (n % 2 == 1));
            Console.WriteLine(string.Join(", ", oddNums));

            List<int> war100 = war.Where(w => w.Height == 100)
                                  .Select(w => w.Height)
                                  .ToList();
            //foreach in lambda - works only for lists
            war100.ForEach(w => Console.WriteLine(w));

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tod",180,70,Gender.Male),
            //    new Person("John",170,88,Gender.Male),
            //    new Person("Anna",150,48,Gender.Female),
            //    new Person("Kyle",164,77,Gender.Male),
            //    new Person("Anna",164,77,Gender.Male),
            //    new Person("Maria",16,55,Gender.Female),
            //    new Person("John",160,55,Gender.Male),
            //};

            //var selectedPeople = from person in people
            //                     where person.Name.Length > 1
            //                     orderby person.Name,person.Weight
            //                     select person;
            //foreach (var item in selectedPeople)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Weight}kg");
            //}



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

    internal class Warrior
    {
        public int Height { get; set; }
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
