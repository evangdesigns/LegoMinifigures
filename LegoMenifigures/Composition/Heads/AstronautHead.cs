using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    class AstronautHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }

        public void Talk()
        {
            Console.WriteLine($"The atronaut says 'Major Tom to Ground Control,' with {FacialExpression}" );
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
                Console.WriteLine("Mmmm Pie....");
            else
                Console.WriteLine("You Call thsi Pie!!!");
        }
    }
    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange
    }
}
