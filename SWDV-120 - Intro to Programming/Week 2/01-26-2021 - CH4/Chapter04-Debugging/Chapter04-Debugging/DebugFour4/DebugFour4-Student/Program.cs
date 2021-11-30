using System;
using static System.Console;
namespace DebugFour4
{
    class Program
    {
        static void Main(string[] args)
        {
            string less10st, enter20st;
            int less10, enter20;
            int number = 0;

            do
            {
                WriteLine("Enter a value greater than 10: ");
                less10st = ReadLine();
                less10 = int.Parse(less10st);

                if (less10 >= 10)
                {
                    WriteLine("{0} is greater than or equal to 10", less10);
                }
                else
                {
                    WriteLine("Please enter a value greater than 10 as instructed!");
                    WriteLine("Better luck next time");
                    WriteLine("{0} is less than 10", less10);
                }

                WriteLine("\nEnter a value greater than 20: ");
                enter20st = ReadLine();
                enter20 = int.Parse(enter20st);

                if (enter20 > 20)
                {
                    WriteLine("Congratulations, you can follow instructions");
                    WriteLine("{0} is greater than 20", enter20);
                }
                else
                {
                    if (enter20 < 20)
                    {

                        WriteLine("{0} is less than or equal to 20", enter20);
                        WriteLine("Better luck next time");
                    }
                    else
                    {
                        WriteLine("Right on the money");
                        WriteLine("You entered {0}", enter20);
                    }
                }
                WriteLine("End of the program..\n");
                number++;
            } while (number < 5);
        }
    }
}
