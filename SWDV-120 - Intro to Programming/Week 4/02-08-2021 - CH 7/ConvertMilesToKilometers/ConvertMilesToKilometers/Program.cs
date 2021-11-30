using System;
using static System.Console;
namespace ConvertMilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;

            Write("Enter miles >> ");
            miles = int.Parse(ReadLine());

            WriteLine("{0} miles is {1} kilometers", miles, ComputeMiles(miles));
        }
        static double ComputeMiles(double miles)
        {
            const double km = 1.60934;
            double convertMiles;
            convertMiles = miles * km;
            return convertMiles;
        }
    }
}
