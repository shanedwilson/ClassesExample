using ClassesExamples.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex = Sex.Shrug, Colors color = Colors.Red)
            : base(numberOfArms, sex, color, "OMG, so fit.")
        {
        }

        public void Crunch(int howManyCrunches)
            {
                FitnessOfAbdomen = FitnessOfAbdomen + " Even more fit.";
                Console.WriteLine($"I just did {howManyCrunches}, brh. CROSSFIT!");
            }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");
        }
    }
}
