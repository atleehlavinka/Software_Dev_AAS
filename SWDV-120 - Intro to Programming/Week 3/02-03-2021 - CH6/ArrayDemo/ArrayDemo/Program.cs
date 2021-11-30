using System;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myValues = { 7, 6, 3, 2, 1, 8, 4, 5 };
            int y, i;
            const int QUIT = 4;
            string userInput;
            int number = 0, numberOption3, userOption3;

            while (number != QUIT)
            {

                WriteLine("Choose one: \n1 : to view the list in order first to last\n2 : to view the list in order last to first\n3 : choose a specific position to view\n4 to exit program\n--------------------------------------------");
                number = Convert.ToInt32(ReadLine());
                if (number == 1)
                {
                    WriteLine("  List in order from first to last");
                    for (i = 0; i < myValues.Length; ++i)
                        Write("{0, 4}", myValues[i]);
                    WriteLine();
                } 
                else if (number == 2)
                {
                    Array.Reverse(myValues);
                    WriteLine("  List in order from first to last");
                    for (y = 0; y < myValues.Length; ++y)
                        Write("{0, 4}", myValues[y]);
                    WriteLine();
                    Array.Reverse(myValues);
                } 
                else if (number == 3)
                {
                    Write("  What position from 1 to 8 would you like to see? ");
                    numberOption3 = Convert.ToInt32(ReadLine());
                    userOption3 = numberOption3 - 1;

                    if (numberOption3 < 0 || numberOption3 > 9)
                    {
                        WriteLine("  That number is outside the boundary of the list");
                    }
                    else
                    {
                        WriteLine("  The list element in position {0} --> {1}", numberOption3, myValues[userOption3]);
                    }
                }
                else if (number < 1 || number > 4)
                {
                    WriteLine("  Invalid Entry: {0}. Must choose either 1, 2, 3, or 4 to exit", number);
                }
                WriteLine();
            }
        }
    }
}
