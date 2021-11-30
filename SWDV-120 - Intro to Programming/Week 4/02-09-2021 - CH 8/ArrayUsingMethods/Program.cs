using System;
using static System.Console;
namespace ArrayUsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numArray = new int[100];
            int total = 0;

            UserArray(out count, out numArray, out total);

            for (int y = 0; y < count; ++y)
                Write("\t{0}", numArray[y]);

            WriteLine("\nYou entered {0} numbers", count);
            WriteLine("The total of those {0} numbers is {1}", count, total);
        }
        public static void UserArray(out int count, out int[] numArray, out int total)
        {
            const int QUIT = 999;
            int[] numbers = new int[20];
            int x = 0;
            int num;
            double average;
            total = 0;
            string inString;
            count = 0;
            numArray = new int[10];



            Write("Please enter a number or " + QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);

            while ((x < numArray.Length) && num != QUIT)
            {
                numArray[x] = num;
                total += numArray[x];
                count = count + 1;
                ++x;
                if (x < numArray.Length)
                {
                    Console.Write("Please enter a number or " + QUIT + " to quit...");
                    inString = ReadLine();
                    num = Convert.ToInt32(inString);
                }
            }
        }
    }
}
