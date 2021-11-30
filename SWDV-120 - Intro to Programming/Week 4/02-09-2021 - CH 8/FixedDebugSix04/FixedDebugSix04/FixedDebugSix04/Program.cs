// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class FixedDebugSix04
{
    static void Main()
    {
        const int QUIT = 999;
        int[] numbers = new int[10];
        int x;
        int num;
        double average;
        double total = 0;
        string inString;
        Write("Please enter a number or " +
           QUIT + " to quit...");
        inString = ReadLine();
        num = Convert.ToInt32(inString);
        x = 0;
        while ((x < numbers.Length) && num != QUIT)
        {
            numbers[x] = num;
            total += numbers[x];
            ++x;
            if (x < numbers.Length)
            {
                Console.Write("Please enter a number or " +
                   QUIT + " to quit...");
                inString = ReadLine();
                num = Convert.ToInt32(inString);
            }
        }
        WriteLine("The numbers are:");
        for (int y = 0; y < x; ++y)
            Write("{0,6}", numbers[y]);
        average = total / x;
        WriteLine();
        WriteLine("The average is {0}", average);
    }
}

