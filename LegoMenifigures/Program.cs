using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torso;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new AstronautHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstroLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var torso = new AstroTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true,
            };

            var astronaut = new Astronaut("Space Person","Janitor", head, torso, legs);
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            {
                Friendly = true,
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1925,12,01))
            {
                Friendly = false,
            };

            fatso.Spook();
            fatso.Haunt("Whipstaff Manor");
            fatso.Spook();

        }
    }
}
