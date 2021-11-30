using System;
using static System.Console;
namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FEETINMILE = 5280;
            string enterMiles;
            double miles, convertMiles;

            Write("Enter the number of miles: ");
            enterMiles = ReadLine();
            miles = Convert.ToDouble(enterMiles);

            convertMiles = miles * FEETINMILE;
            WriteLine("The distance to my uncle's house is {0} miles or {1} feet", miles, convertMiles);
        }
    }
}
