using System;
using System.Linq;

namespace LINQ_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 13, 653, 3, 4, 5, 6, 7 };

            var getTheNumbers = from number in numbers
                                where number <=4
                                select number;

            var catsWithA = from cat in catNames
                            where cat.Contains('a') && cat.Length<5
                            select cat;

            Console.WriteLine(string.Join(", ", getTheNumbers));
            Console.WriteLine(string.Join(", ", catsWithA));
        }
    }
}
