using System;
using System.Collections.Generic;

namespace ClassesExamples.Legos.Torsos
{
    class Scaley : Torso
    {
        public Scaley()
            : base(4, Sex.Other, Colors.Red, "Hard as a rock")
        {
        }

        public override void Wave()
        {
            Console.WriteLine(@"Fragile waving \0/");
        }
    }
}
