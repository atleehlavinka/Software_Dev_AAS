/* Atlee Hlavinka
 * SWDV-120 - 001R - Introduction to Programming
 * Prof. Elisa Lowenstein
 * Final Programming Project 
 */

using System;
using static System.Console;
namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int[] numArray = new int[10];
            int count = 0;
            int total = 0;
            int min;
            int max;
            double average = 0;

            //Call Methods
            FillArray(out numArray, out count, out total);
            Statistics(numArray, count, total, out average, out min, out max);

            //Display array
            for (int y = 0; y < count; ++y)
                Write("{0} ", numArray[y]);
            WriteLine();

            //Statistics
            WriteLine("The array has {0} values", count);
            WriteLine("The highest value is {0}", max);
            WriteLine("the lowest value is {0}", min);
            WriteLine("The sum of the values is {0}", total);
            WriteLine("The average is {0}", average);
        }

        //Method to fill an array and give basic info for the statistics method.
        public static int[] FillArray(out int[] numArray, out int count, out int total)
        {
            //Variables
            numArray = new int[10];
            total = 0;
            count = 0;
            const int QUIT = 999;
            int x = 0;
            int num;
            string inString;

            //Loop to fill array
            Write("Please enter an integer or 999 to quit >> ");
            inString = ReadLine();
            num = Convert.ToInt32(inString);

            while ((x < numArray.Length) && num != QUIT)
            {
                numArray[x] = num;
                count = count + 1;
                total = +total + num;
                ++x;
                if (x < numArray.Length)
                {
                    Console.Write("Please enter an integer or 999 to quit >> ");
                    inString = ReadLine();
                    while (!int.TryParse(inString, out num))
                    {
                        WriteLine("\t*** Invalid entry ***");
                        Write("Please enter an integer or 999 to quit >> ");
                        inString = ReadLine();
                    }
                }
            }
            return numArray;
        }

        //Takes array from the FillArray() method and provides information on that array.
        static void Statistics(int[] numArray, int count, int total, out double average, out int min, out int max)
        {
            
            //Finds the average
            average = (double)total / (double)count;

            //Finds min and max values
            min = numArray[0];
            max = numArray[0];
            for (int i = 1; i < count; i++)
            {
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }
                if (numArray[i] < min)
                {
                    min = numArray[i];
                }
            }
        }
    }
}
