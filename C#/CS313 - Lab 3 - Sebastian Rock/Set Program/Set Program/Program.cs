//
//	Program:		Set Program
//
//	Description:	Tests out the set program
//
//	Program history:
//
//		Date	Programmer	        Change
//		-------	------------------	-----------
//	02/25/14	  Sebastian Rock	Program written
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Testing the Set Program----");
            Console.WriteLine("Creating a set...");
            Set<int> testerSet = new Set<int>();
            testerSet.Insert(4);
            testerSet.Insert(7);
            testerSet.Insert(9);
            testerSet.PrintSet();
            Console.Write("\n");
            Console.WriteLine("Length of the first set...{0}", testerSet.Cardinality());

            Console.WriteLine("\nCreating another set...");
            Set<int> testerSet2 = new Set<int>();
            testerSet2.Insert(4);
            testerSet2.Insert(7);
            testerSet2.PrintSet();
            Console.Write("\n");
            Console.WriteLine("Length of the second set...{0}", testerSet2.Cardinality());

            Console.WriteLine("\nIs the first set a subset of the second? {0}", testerSet.SubsetOf(testerSet2));
            Console.WriteLine("Is the second set a subset of the first? {0}", testerSet2.SubsetOf(testerSet));
            Console.WriteLine("Are the two sets equal? {0}", testerSet.Equal(testerSet, testerSet2));

            Console.WriteLine("\nCreating a set of the union of the two sets...");
            Set<int> unionSet = new Set<int>();
            unionSet = testerSet + testerSet2;
            unionSet.PrintSet();
            Console.Write("\n");

            Console.WriteLine("\nCreating a set of the intersection of the two sets...");
            Set<int> intersectSet = new Set<int>();
            intersectSet = testerSet * testerSet2;
            intersectSet.PrintSet();
            Console.Write("\n");

            Console.WriteLine("\nCreating a set of the subtraction of the two sets...");
            Set<int> subtractSet = new Set<int>();
            subtractSet = testerSet - testerSet2;
            subtractSet.PrintSet();
            Console.Write("\n");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
