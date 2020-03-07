using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Ghost
    {
        public bool Friendly { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; set; }
        public DateTime DeathDay { get; set; }

        public Ghost(string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string location)
        {
            HauntingLocation = location;
            Console.WriteLine($"{Name} has moved into {HauntingLocation}");
        }
        
        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;
            
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
