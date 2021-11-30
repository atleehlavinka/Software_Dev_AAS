using System;
using static System.Console;

namespace MonthNames
{
    class Program
    {
        enum monthsOfTheYear
        { JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER}
        static void Main(string[] args)
        {
            string enterMonth;
            int monthNum;

            Write("Enter a month number (1-12) ");
            enterMonth = ReadLine();
            monthNum = Convert.ToInt32(enterMonth);

            WriteLine("You entered the value for {0}", (monthsOfTheYear)monthNum - 1);
        }
    }
}
