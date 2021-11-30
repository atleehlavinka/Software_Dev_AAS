using System;
using static System.Console;
namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0, totalNums = 0;
            const int STOP = 999;
            string inputString;

            while (inputNum != 999)
            {
                Write("Enter a number or {0} to quit >> ", STOP);
                inputString = ReadLine();
                while (!int.TryParse(inputString, out inputNum))
                {
                    WriteLine("Input data was not formatted correctly");
                    Write("Please enter a number again >> ");
                    inputString = ReadLine();
                }
                if (inputNum != 999)
                    totalNums = totalNums + inputNum;
            }
            WriteLine("\n The sum is {0}", totalNums);
        }
    }
}
