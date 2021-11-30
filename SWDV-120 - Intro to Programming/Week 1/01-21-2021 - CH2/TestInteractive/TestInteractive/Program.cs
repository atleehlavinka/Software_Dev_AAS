using System;
using static System.Console;
namespace TestInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            const double NUMTESTS = 8;
            string testOne, testTwo, testThree, testFour, testFive, testSix, testSeven, testEight;
            int calcOne, calcTwo, calcThree, calcFour, calcFive, calcSix, calcSeven, calcEight, total;
            double avg, calcAvg;

            //Enter Test Scores for 1 - 8
            Write("Enter test score 1 >> ");
            testOne = ReadLine();
            calcOne = Convert.ToInt16(testOne);

            Write("Enter test score 2 >> ");
            testTwo = ReadLine();
            calcTwo = Convert.ToInt16(testTwo);

            Write("Enter test score 3 >> ");
            testThree = ReadLine();
            calcThree = Convert.ToInt16(testThree);

            Write("Enter test score 4 >> ");
            testFour = ReadLine();
            calcFour = Convert.ToInt16(testFour);

            Write("Enter test score 5 >> ");
            testFive = ReadLine();
            calcFive = Convert.ToInt16(testFive);

            Write("Enter test score 6 >> ");
            testSix = ReadLine();
            calcSix = Convert.ToInt16(testSix);

            Write("Enter test score 7 >> ");
            testSeven = ReadLine();
            calcSeven = Convert.ToInt16(testSeven);

            Write("Enter test score 8 >> ");
            testEight = ReadLine();
            calcEight = Convert.ToInt16(testEight);

            //Calculations
            total = calcOne + calcTwo + calcThree + calcFour + calcFive + calcSix + calcSeven + calcEight;
            avg = total / NUMTESTS;

            //calcAvg = Math.Round(avg, 2);


            //Output
            WriteLine("The average test score is {0}", avg.ToString("F2"));

        }
    }
}
