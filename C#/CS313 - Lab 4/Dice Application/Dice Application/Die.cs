using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Application
{
    public class Die
    {
        private int numberSides;
        private string color;
        private int sideUp;

        private static readonly Random roller = new Random();

        public Die()
            : this(6, "black")
        {
        }

        public Die(int numberSides)
            : this(numberSides, "black")
        {
        }

        public Die(string color)
            : this(6, color)
        {
        }

        public Die(int numberSides, string color)
        {
            this.numberSides = numberSides;
            this.color = color;
            this.Roll();
        }

        public int NumberSides
        {
            get { return numberSides; }
        }

        public int Roll()
        {
            this.sideUp = roller.Next(this.numberSides) + 1;
            return this.sideUp;
        }

        public string DieColor
        {
            get { return color; }
        }

        public int SideUp
        {
            get { return sideUp; }
        }

        public static int operator +(Die d1, Die d2)
        {
            return d1.sideUp + d2.sideUp;
        }

    }
}
