// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
    public static void Main()
    {
        const int QUIT = 999;
        int[] numbers = new int[20];
        int x = 0;
        int num;
        double average;
        double total = 0;
        string inString;

        Write("Please enter a number or " + QUIT + " to quit...");
        inString = ReadLine();
        num = Convert.ToInt32(inString);

        while ((x < numbers.Length) && num != QUIT)
        {
            numbers[x] = num;
            total += numbers[x]; //x += y x = x + y
            ++x;

            Write("Please enter a number or " + QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
        }

        WriteLine("The numbers are:");
        for (int y = 0; y < x; y++)
           Write ("\t{0}", numbers[y]);

        WriteLine("\n");

        average = total / x;
        WriteLine("The average is {0}", average);
    }
}
