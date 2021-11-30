using System;
using static System.Console;

class WhatDay
{
    // Page 84 Working with Enumerations
    enum daysOfTheWeek
    { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    static void Main()
    {
        string enterDay;
        int dayNum;

        Write("Enter the numerical value the day: ");
        enterDay = ReadLine();
        dayNum = Convert.ToInt32(enterDay);

        WriteLine("The name of the day {0} is {1}", dayNum, (daysOfTheWeek)dayNum);
        WriteLine("The name of the day {0} is {1}", dayNum, (daysOfTheWeek)4);
    } // Main
} // Class
