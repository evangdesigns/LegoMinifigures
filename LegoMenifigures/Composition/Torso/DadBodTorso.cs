using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torso
{
    class DadBodTorso : TorsoBase
    {
        public bool IsHairy { get; set; }
        public override bool ChiseledAbs
        { 
            get { return false; } 
            set { }
        }

        public void ChangeTeperature(string weather)
        {
            if(weather == "cold")
            {
                Console.WriteLine("Dad bod turns down the thermostst.");
            }
            else
            {
                Console.WriteLine("Dad bod turns up thermostat");
            }
        }

        public override void Flex()
        {
            Console.WriteLine($"The dad bod flexes his {(IsHairy ? "Hairy" : "Smooth")} beer belly while using his {HandType} hands to point at his flabby arms.");
        }
    }
}
