using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stopEnterNums = 999;
            int inputNum = 0, totalNums = 0;
            string entryString = "";


            while (inputNum != stopEnterNums)
            {
                //Code added from page 316
                WriteLine("Enter an integer to add or enter 999 to get the total: ");
                entryString = ReadLine();
                while (!int.TryParse(entryString, out inputNum))
                {
                    WriteLine(" ** Input data was not formatted correctly ** ");
                    Write("Enter a number or 999 to exit: ");
                    entryString = ReadLine();
                } // while
                if (inputNum != 999) //need this so 999 is not added to total
                    totalNums = +totalNums + inputNum;
            }
            WriteLine("The total is: {0}", totalNums);
        }
    }
}
