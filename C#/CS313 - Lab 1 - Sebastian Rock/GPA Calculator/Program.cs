//
//	Program:		GPA Calculator
//
//	Description:	Calculates the GPA of a student, and totals the number of
//                  A's, B's, C's, D's, and F's they got.
//
//	Program history:
//
//		Date	Programmer	        Change
//		-------	------------------	-----------
//	02/03/14	  Sebastian Rock	Program written
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_calculator
{
    class Program
    {

        static void gradePicker(ref int QualityAs, ref int QualityBs, ref int QualityCs, ref int QualityDs,
            ref int QualityFs, ref int numAs, ref int numBs, ref int numCs, ref int numDs, ref int numFs,
            char courseGrade, int courseHours)
        {
            switch (courseGrade)
            {
                case 'A':
                    QualityAs += 4 * courseHours;
                    numAs += 1;
                    break;
                case 'B':
                    QualityBs += 3 * courseHours;
                    numBs += 1;
                    break;
                case 'C':
                    QualityCs += 2 * courseHours;
                    numCs += 1;
                    break;
                case 'D':
                    QualityDs += 1 * courseHours;
                    numDs += 1;
                    break;
                case 'F':
                    QualityFs += 0;
                    numFs += 1;
                    break;

            }
        }

        static void printResults(int QualityAs, int QualityBs, int QualityCs, int QualityDs, int numAs,
            int numBs, int numCs, int numDs, int numFs, string studentName, int totalHours, ref double GPA)
        {
            if (totalHours != 0)
                GPA = (QualityAs + QualityBs + QualityCs + QualityDs) / totalHours;
            else
                GPA = 0;

            Console.WriteLine("Student Name: {0}", studentName);
            Console.WriteLine("GPA: {0}", GPA);
            Console.WriteLine("Hours: {0}", totalHours);
            Console.WriteLine("Number of A's: {0}", numAs);
            Console.WriteLine("Number of B's: {0}", numBs);
            Console.WriteLine("Number of C's: {0}", numCs);
            Console.WriteLine("Number of D's: {0}", numDs);
            Console.WriteLine("Number of F's: {0}", numFs);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void inputGrades(ref int QualityAs, ref int QualityBs, ref int QualityCs, ref int QualityDs,
            ref int QualityFs, ref int numAs, ref int numBs, ref int numCs, ref int numDs, ref int numFs,
            ref int courseHours, ref int totalHours, ref string studentName)
        {
            char courseGrade;

            Console.WriteLine("Enter student name: ");
            studentName = Console.ReadLine();

            do
            {
                Console.Write("Enter course credit hours (enter 0 if done): ");
                courseHours = Convert.ToInt32(Console.ReadLine());
                if (courseHours != 0)
                {
                    Console.Write("Enter course grade: ");
                    courseGrade = Console.ReadLine().ToUpper()[0];
                    totalHours += courseHours;
                    gradePicker(ref QualityAs, ref QualityBs, ref QualityCs,
                        ref QualityDs, ref QualityFs, ref numAs, ref numBs, ref numCs, ref numDs, ref numFs,
                        courseGrade, courseHours);
                }
            } while (courseHours != 0);
        }

        static void Main(string[] args)
        {
            string answer = " ";
            string studentName = " ";
            double GPA = 0.0;
            int courseHours = 0;
            int totalHours = 0;
            int QualityAs = 0;
            int QualityBs = 0;
            int QualityCs = 0;
            int QualityDs = 0;
            int QualityFs = 0;
            int numAs = 0;
            int numBs = 0;
            int numCs = 0;
            int numDs = 0;
            int numFs = 0;

            do
            {
                inputGrades(ref QualityAs, ref QualityBs, ref QualityCs, ref QualityDs,
                    ref QualityFs, ref numAs, ref numBs, ref numCs, ref numDs, ref numFs,
                    ref courseHours, ref totalHours, ref studentName);

                printResults(QualityAs, QualityBs, QualityCs, QualityDs, numAs,
                numBs, numCs, numDs, numFs, studentName, totalHours, ref GPA);

                Console.WriteLine("Submit a new student? Yes/No");
                answer = Console.ReadLine().ToUpper();
            } while (answer != "NO");
        }
    }
}