//
//	Program:		Die/Dice Program
//
//	Description:	Creates classes for die and dice
//
//	Program history:
//
//		Date	Programmer	        Change
//		-------	------------------	-----------
//	02/24/14	  Sebastian Rock	Program written
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Application
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("----TESTING DIE CLASS----");

            Console.WriteLine("\nCreating two instances of dice...");
            Die testerDie = new Die("blue", 6);
            Die testerDie2 = new Die();

            Console.WriteLine("Die 1 Color: {0} and Sides: {1}", testerDie.Color, testerDie.NumOfSides);
            Console.WriteLine("Die 2 Color: {0} and Sides: {1}", testerDie2.Color, testerDie2.NumOfSides);

            Console.WriteLine("Rolling the dice...");
            testerDie.Roll();
            testerDie2.Roll();

            Console.WriteLine("Die 1: {0}", testerDie.FaceValue);
            Console.WriteLine("Die 2: {0}", testerDie2.FaceValue);

            Console.WriteLine("Adding two dice...");

            Console.WriteLine("The two face values equals...{0}", testerDie + testerDie2);

            Console.WriteLine("\n----TESTING DICE CLASS----");
            Console.WriteLine("Adding dice to cup...");

            Dice cuppaDie = new Dice(2);
            cuppaDie.Add(testerDie);
            cuppaDie.Add(testerDie2);

            Console.WriteLine("Rolling the dice...");
            cuppaDie.Roll();
            Console.WriteLine("Die 1: {0}", cuppaDie.DieAt(0).FaceValue);
            Console.WriteLine("Die 2: {0}", cuppaDie.DieAt(1).FaceValue);

            Console.WriteLine("\nNumber of dice with the face value of 2...{0}", cuppaDie.CountValue(2));
            Console.WriteLine("Total value of the dice...{0}", cuppaDie.Total());
            Console.WriteLine("Highest face value...{0}", cuppaDie.HighValue());
            Console.WriteLine("Lowest face value...{0}", cuppaDie.LowValue());

            Console.WriteLine("\nWithholding the first die...");
            cuppaDie.DieAt(0).WithholdDie = true;
            Console.WriteLine("Rolling again...");
            cuppaDie.Roll();
            Console.WriteLine("Die 1: {0}", cuppaDie.DieAt(0).FaceValue);
            Console.WriteLine("Die 2: {0}", cuppaDie.DieAt(1).FaceValue);

            Console.WriteLine("\nRolling again...");
            cuppaDie.Roll();
            Console.WriteLine("Die 1: {0}", cuppaDie.DieAt(0).FaceValue);
            Console.WriteLine("Die 2: {0}", cuppaDie.DieAt(1).FaceValue);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }
    }
}
