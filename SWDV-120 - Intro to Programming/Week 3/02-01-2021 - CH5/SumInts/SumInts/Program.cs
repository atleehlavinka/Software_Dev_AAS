using System;
using static System.Console;
namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sentinel = 999;
            int enterInt, total = 0;

            WriteLine("Enter an integer to add or enter {0} to get the total:", sentinel);
            enterInt = Convert.ToInt32(ReadLine());

            while (enterInt != 999)
            {
                total = total + enterInt;
                WriteLine("Enter an integer to add or enter {0} to get the total:", sentinel);
                enterInt = Convert.ToInt32(ReadLine());
            }
            WriteLine("The total is: {0}", total);
        }
    }
}