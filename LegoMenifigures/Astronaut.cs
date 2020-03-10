using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torso;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }

    class Astronaut
    {
        //Public proberty
        public Location Location { get; set; }
        //Expression Bodied Property
        public bool SuitedUp => Name == "Space Guy"; //Read only Property. Always "true"
        // Read-Only Property
        public string Name { get; } //Allows value to be set at the instance of the class
        //Public property with a private setter
        public string Job { get; private set; } //Same as above, alternative to writing it
        public int OxygenLevel { private get; set; }

        public AstroTorso Torso { get; set; }
        public AstroLegs Legs { get; set; }
        public AstronautHead Head { get; set; }

        public Astronaut( string name, string job,
            AstronautHead head,
            AstroTorso torso,
            AstroLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commanding Janitor";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all of their {Job} duties...");
            Legs.Walk(15);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(10);

        }

    }
}
