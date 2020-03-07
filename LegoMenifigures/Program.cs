using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person","Janitor");
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
