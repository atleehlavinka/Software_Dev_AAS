using System;
using static System.Console;
namespace TestScoreList
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[8];
            int x = 0, y = 1;
            int num;
            double average, fromAverage;
            double total = 0.00;
            string inString;

            while (x < numbers.Length)
            {
                Write("Please enter score for test number {0} >> ", y);
                inString = ReadLine();
                num = Convert.ToInt32(inString);

                numbers[x] = num;
                total += numbers[x];
                x++;

                y++;
            }
            y = 1;
            average = total / x;
            WriteLine("\nScores for the tests are:\n");
            for (int z = 0; z < x; z++)
            {
                fromAverage = numbers[z] - average; 
                Write("Test # {0} : {1} From average: {2}\n", y, numbers[z], fromAverage);
                y++;
            }

            WriteLine();
            WriteLine("  Total is {0}", total);
            WriteLine("Average is  {0}", average);
        }
    }
}
