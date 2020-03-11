﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Legs
{
    class BabyLegs
    {

        public bool CanWalk { get; set; }
        public int NumbOfRolls { get; set; }
        public bool IsClumbsy => true;
        public bool HasPAnts { get; set; }

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk around {steps} steps and then fall down.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet.");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with the power of {NumbOfRolls}.");
        }
    }
}
