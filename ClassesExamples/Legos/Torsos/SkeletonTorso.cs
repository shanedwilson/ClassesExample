﻿using ClassesExamples.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Torsos
{
    class SkeletonTorso : Torso
    {
        public SkeletonTorso(int numberOfArms) : base(numberOfArms, Sex.Shrug, Colors.Bone, "boney")
        {

        }
        public void Rattle()
        {
            Console.WriteLine("Rattle Rattle...");
            Wave();
        }
    }
}
