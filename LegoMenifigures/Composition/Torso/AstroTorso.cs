using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torso
{
    class AstroTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }
        public override bool ChiseledAbs { get; set; }

        public override void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show. Pew Pew!");
            }
            else
            {
                Console.WriteLine("Weird Flex, but Ok.");
            }
        }
        public override void Breathe()
        {
            Console.WriteLine("Inhale, Exhale...");
        }
    }
}
