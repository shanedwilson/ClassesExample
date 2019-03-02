using System;

namespace ClassesExamples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "I knda liked it.");

            Console.WriteLine(taffy.ToString());
            Console.ReadKey();
        }
    }
}
