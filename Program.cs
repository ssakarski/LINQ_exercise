using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collection filtering by type of items
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd",'s',"Hello Kitty",1,2,3,4 };

            var allIntegers = mix.OfType<int>();

            var allListsOfInt = mix.OfType<List<int>>();

            Console.WriteLine(string.Join(", ",allIntegers));
            Console.WriteLine();
            // lists of ints
            foreach (var num in allListsOfInt)
            {
                Console.WriteLine(string.Join(", ",num));
            }



            ////Join operation
            //List<Buyer> buyers = new List<Buyer>()
            //{
            //    new Buyer(){ Name = "Johny", District = "Fantasy District", Age = 22},
            //    new Buyer(){ Name = "Peter", District = "Scientists District", Age = 40},
            //    new Buyer(){ Name = "Paul", District = "Fantasy District", Age = 30},
            //    new Buyer(){ Name = "Maria", District = "Scientists District", Age = 35},
            //    new Buyer(){ Name = "Joshua", District = "EarthIsFlat District", Age = 40},
            //    new Buyer(){ Name = "Sylvia", District = "Developers District", Age = 22},
            //    new Buyer(){ Name = "Rebecca", District = "Scientists District", Age = 30},
            //    new Buyer(){ Name = "Jaime", District = "Developers District", Age = 35},
            //    new Buyer(){ Name = "Pierce", District = "Fantasy District", Age = 40}
            //};

            //List<Supplier> suppliers = new List<Supplier>()
            //{
            //    new Supplier(){ Name = "Harrison", District = "Fantasy District", Age = 22},
            //    new Supplier(){ Name = "Charles", District = "Developers District", Age = 40},
            //    new Supplier(){ Name = "Hailee", District = "Scientists District", Age = 35},
            //    new Supplier(){ Name = "Taylor", District = "EarthIsFlat District", Age = 30}
            //};

            //var innerJoin = from s in suppliers
            //                join b in buyers on s.District equals b.District
            //                select new
            //                {
            //                    SupplierName = s.Name,
            //                    BuyerName = b.Name,
            //                    District = s.District
            //                };
            //foreach (var item in innerJoin)
            //{
            //    Console.WriteLine($"{item.District}");
            //    Console.WriteLine($"Supplier: {item.SupplierName} - Buyer: {item.BuyerName}");
            //}





            ////Grouping with lambda
            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tod",180,70,Gender.Male),
            //    new Person("John",170,88,Gender.Male),
            //    new Person("Anna",150,48,Gender.Female),
            //    new Person("Kyle",164,77,Gender.Male),
            //    new Person("Anna",164,77,Gender.Male),
            //    new Person("Maria",160,55,Gender.Female),
            //    new Person("John",160,55,Gender.Male),
            //};

            //// grouping by height
            //var simpleGrouping = people.Where(p => p.Height > 150)
            //                           .GroupBy(p => p.Gender);

            //foreach (var p in simpleGrouping)
            //{
            //    Console.WriteLine($"{p.Key}");
            //    foreach (var item in p)
            //    {
            //        Console.WriteLine($"    {item.Name} - {item.Height} - {item.Gender}");
            //    }
            //}
            //Console.WriteLine();


            //// grouping by first letter
            //var alphabeticalGroup = people.OrderBy(p => p.Name)
            //                              .GroupBy(p => p.Name[0]);

            //foreach (var p in alphabeticalGroup)
            //{
            //    Console.WriteLine($"{p.Key}");
            //    foreach (var item in p)
            //    {
            //        Console.WriteLine($"    {item.Name}");
            //    }
            //}
            //Console.WriteLine();


            ////multi key groups - name / gender
            //var multiKeyGroup = people.GroupBy(p => new { p.Name, p.Gender }).OrderBy(p => p.Count());

            //foreach (var p in multiKeyGroup)
            //{
            //    Console.WriteLine($"{p.Key}");
            //    foreach (var item in p)
            //    {
            //        Console.WriteLine($"    {item.Name}");
            //    }
            //}




            //// Grouping
            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tod",180,70,Gender.Male),
            //    new Person("John",170,88,Gender.Male),
            //    new Person("Anna",150,48,Gender.Female),
            //    new Person("Kyle",164,77,Gender.Male),
            //    new Person("Anna",164,77,Gender.Male),
            //    new Person("Maria",160,55,Gender.Female),
            //    new Person("John",160,55,Gender.Male),
            //};

            //var genderGroup = from p in people
            //                  group p by p.Gender;

            //foreach (var person in genderGroup)
            //{
            //    Console.WriteLine($"{person.Key}");
            //    foreach (var p in person)
            //    {
            //        Console.WriteLine($"    {p.Name} - {p.Gender}");
            //    }
            //}

            //// grouping by height
            //var groupByHeight = from p in people
            //                 where p.Height > 160
            //                 group p by p.Height;

            //foreach (var person in groupByHeight)
            //{
            //    Console.WriteLine($"{person.Key}");
            //    foreach (var p in person)
            //    {
            //        Console.WriteLine($"    {p.Name} - {p.Height}");
            //    }
            //}

            ////grouping by first letter of the name
            //var groupByFirstLetter = from p in people
            //                         orderby p.Name
            //                         group p by p.Name[0];

            //foreach (var person in groupByFirstLetter)
            //{
            //    Console.WriteLine($"{person.Key}");
            //    foreach (var p in person)
            //    {
            //        Console.WriteLine($"    {p.Name}");
            //    }
            //}






            ////Lambda queries
            //string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            //List<int> numbers = new List<int>(){ 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 13, 653, 3, 4, 5, 6, 7 };
            //object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd"};
            //List<Warrior> war = new List<Warrior>()
            //{
            //    new Warrior(){Height = 100},
            //    new Warrior(){Height = 80},
            //    new Warrior(){Height = 100},
            //    new Warrior(){Height = 70}
            //};

            //var oddNumbers = from n in numbers
            //                 where n % 2 == 1
            //                 select n;

            //// doing the same but with lambda expression
            //var oddNums = numbers.Where(n => (n % 2 == 1));
            //Console.WriteLine(string.Join(", ", oddNums));

            //List<int> war100 = war.Where(w => w.Height == 100)
            //                      .Select(w => w.Height)
            //                      .ToList();
            ////foreach in lambda - works only for lists
            //war100.ForEach(w => Console.WriteLine(w));

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tod",180,70,Gender.Male),
            //    new Person("John",170,88,Gender.Male),
            //    new Person("Anna",150,48,Gender.Female),
            //    new Person("Kyle",164,77,Gender.Male),
            //    new Person("Anna",164,77,Gender.Male),
            //    new Person("Maria",160,55,Gender.Female),
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





            ////Basic linq queries
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
    internal class Supplier
    {
        public int Age { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
    }

    internal class Buyer
    {
        public int Age { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
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
