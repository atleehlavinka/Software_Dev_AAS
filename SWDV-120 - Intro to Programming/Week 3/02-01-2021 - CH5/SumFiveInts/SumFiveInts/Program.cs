using System;
using static System.Console;
namespace SumFiveInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int inputLimit = 5;
            int enterNumber, total = 0;
            int sumInts, counter = 1;

            while (counter <= inputLimit)
            {
                Write("Enter a number >> ");
                enterNumber = Convert.ToInt32(ReadLine());
                total = total + enterNumber;
                counter++;
            }
            sumInts = total;
            WriteLine("\nThe sum is {0}", total);
        }
    }
}
