using System;
using static System.Console;
namespace ArrayUsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int count = 0;
            int[] numArray = new int[100];
            double average = 0;
            double useravg = 0;

            FillArray(out count, out numArray, out average);

            for (int y = 0; y < count; ++y)
                Write("{0} ", numArray[y]);
            Write(" -- Average is {0}", average.ToString("F2"));
            WriteLine("\n\n******************************");
            DisplayAverage(3);
            DisplayAverage(12, 15);
            DisplayAverage(22.3, 44.5, 88.1);

        }
        public static void FillArray(out int count, out int[] numArray, out double average)
        {
            const int QUIT = 999;
            int x = 0;
            int num;
            int total = 0;
            string inString;
            count = 0;
            numArray = new int[10];

            Write("Enter a number >> ");
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
                    Console.Write("Enter a number >> ");
                    inString = ReadLine();
                    while (!int.TryParse(inString, out num))
                    {
                        WriteLine("Input data was not formatted correctly");
                        Write("Please enter a number >> ");
                        inString = ReadLine();
                    }
                }
            }
            average = (double)total / (double)count;
        }
        public static void DisplayAverage(params double[] numbersPassedIn)
        {
            double total = 0;
            double useravg = 0;

            for (int x = 0; x < numbersPassedIn.Length; ++x)
            {
                Write("{0} ", numbersPassedIn[x]);
                total = total + numbersPassedIn[x];
            }
            useravg = total / numbersPassedIn.Length;
            Write(" -- Average is {0}", useravg.ToString("F2"));
            WriteLine("\n\n******************************");
        }
    }
}
