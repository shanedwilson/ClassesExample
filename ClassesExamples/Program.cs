using ClassesExamples.Legos;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;
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

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaught = new Astronaut();

            var fitTorso = new FitTorso(2, Sex.Male, Colors.Freckles);
            fitTorso.Crunch(12);

            var minifigure = new Minifigure(martinHead, fitTorso);

            minifigure.Greet();

            Console.ReadKey();
        }
    }
}
