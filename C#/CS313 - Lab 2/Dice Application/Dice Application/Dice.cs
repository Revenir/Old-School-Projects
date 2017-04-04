//
//	Program:		Die/Dice Program
//
//	Description:	Contains the Dice class for the application.
//
//	Program history:
//
//		Date		                   Change
//		-------	------------------	-----------
//	      02/24/14	  	               Program written
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_Application
{
    public class Dice: IEnumerable
    {
        private int emptyIndex = 0;
        private Die[] DiceCup = null;

        public Dice(int sizeOfDiceCup)
        {
            DiceCup = new Die[sizeOfDiceCup]; // Create an array to hold the dice
        }

        public void Add(Die die)
        {
            DiceCup[emptyIndex] = die;
            emptyIndex++;
        }

        // IEnumerable Member
        public IEnumerator GetEnumerator()
        {
            foreach (Die die in DiceCup)
            {
                if (die == null)
                {
                    break;
                }
                yield return die;
            }
        }

        public int CountValue(int value)
        {
            int numOfSameValue = 0;

            foreach (Die die in DiceCup)
            {
                if (die == null)
                    break;
                else
                    if (die.FaceValue == value)
                    {
                        numOfSameValue++;
                    }
            }

            return numOfSameValue;
        }
    
        public void Roll()
        {
            foreach (Die die in DiceCup)
            {
                if (die == null)
                    break;
                else
                    if (die.WithholdDie == false)
                        die.Roll();
                    else
                        die.WithholdDie = false; //the die will no longer be withheld
            }
        }

        public Die DieAt(int index)
        {
            return DiceCup[index];
        }

        public int Total()
        {
            int total = 0;

            foreach (Die die in DiceCup)
            {
                if (die == null)
                    break;
                else
                    total += die.FaceValue;
            }

            return total;
        }

        public int HighValue()
        {
            int highestValue = 0;
            foreach (Die die in DiceCup)
            {
                if (die == null)
                    break;
                else
                    if (die.FaceValue > highestValue)
                        highestValue = die.FaceValue;
            }

            return highestValue;
        }

        public int LowValue()
        {
            int lowestValue = DiceCup[0].FaceValue;
            foreach (Die die in DiceCup)
            {
                if (die == null)
                    break;
                else
                    if (die.FaceValue < lowestValue)
                        lowestValue = die.FaceValue;
            }

            return lowestValue;
        }        
    }
}
