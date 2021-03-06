﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Legs
{
    class AstroLegs
    {
        public bool HasPants { get; set; }
        public ShoeType Shoes { get; set; }

        Random _rng = new Random(4);
        public void Walk(int steps)
        {
            Console.WriteLine($"The Astronaut legs moon walked {steps} steps");
        }

        public int Jump()
        {
            var heightOfJump = _rng.Next();

            return heightOfJump;
        }
        
    }
    enum ShoeType
    {
        None,
        Boots,
        FlipFlops,
        Sneakers
    }
}
