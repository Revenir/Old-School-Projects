//
//	Program:		Die/Dice Program
//
//	Description:	Contains the die class for the application
//
//	Program history:
//
//		Date		        Change
//		-------	------------------	-----------
//	02/24/14	  	Program written
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_Application
{
    public class Die
    {
        private string dieColor;
        private int dieNumOfSides;
        private int dieFaceValue;
        private static readonly Random diceRoll = new Random();
        private bool isWithheld;

        public Die()
            : this("black", 6)
        {
            this.isWithheld = false;
            this.dieFaceValue = this.Roll();
        }

        public Die(int NumOfSides)
            : this("black", NumOfSides)
        {
            this.dieFaceValue = this.Roll();
        }

        public Die(string Color)
            : this(Color, 6)
        {
            this.dieFaceValue = this.Roll();
        }
    
        public Die(string Color, int NumOfSides)
        {
            this.dieColor = Color;
            this.dieNumOfSides = NumOfSides;
            this.isWithheld = false;
            this.dieFaceValue = this.Roll();
        }

        public bool WithholdDie //Don't roll the die
        {
            get
            {
                return isWithheld;
            }
            set
            {
                isWithheld = value;
            }
        }

        public int NumOfSides
        {
            get
            {
                return dieNumOfSides;
            }
        }

        public string Color
        {
            get
            {
                return dieColor;
            }
        }

        public int FaceValue
        {
            get
            {
                return dieFaceValue;
            }
        }
    
        public int Roll()
        {
            this.dieFaceValue = diceRoll.Next(1, NumOfSides + 1);
            return this.dieFaceValue;
        }

        static public int operator +(Die die1, Die die2)
        {
            return die1.FaceValue + die2.FaceValue;
        }

    }
}
