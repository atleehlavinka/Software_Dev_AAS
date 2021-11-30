using System;
using static System.Console;

namespace OrderOfPrecedence
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = 5 + 3 * 9;
            WriteLine("5 + 3 * 9 = {0}", result);

            result = (5 + 3) * 9;
            WriteLine("(5 + 3) * 9 = {0}", result);

            result = 17 % 4;
            WriteLine("17 % 4 = {0}", result);

            result = 17 / 4;
            WriteLine("17 / 4 = {0}", result);

            ///*Refer to page 63:
            //"When you divide integers using the / operator, " +
            //    "whether they are integer constants or integer variables, the result is an integer; " +
            //    "in other words, any fractional part of the result is lost. " +
            //    "For example, the result of 45 / 2 is 22 not 22.5 */





            result = 4 + 5 * 6;
            WriteLine("4 + 5 * 6 = {0}", result);

            result = (4 + 5) * 6;
            WriteLine("(4 + 5) * 6 = {0}", result);

            result = 5 + 12 * 4 - 6 * 4;
            WriteLine("5 + 12 * 4 - 6 * 4 = {0}", result);

            result = 33 % 2;
            WriteLine("33 % 2 = {0}", result);

            result = 33 / 2;
            WriteLine("33 / 2 = {0}", result);
        }
    }
}
