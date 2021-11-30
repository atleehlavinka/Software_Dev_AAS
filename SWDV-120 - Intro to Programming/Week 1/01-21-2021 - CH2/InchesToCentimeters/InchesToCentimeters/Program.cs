using System;
using static System.Console;
namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            const double inchToCentimeter = 2.54;
            string inches;
            double calcInches, total;

            //Input Inches
            Write("Enter inches: ");
            inches = ReadLine();
            calcInches = Convert.ToDouble(inches);

            //Calculation
            total = calcInches * inchToCentimeter;

            //Ouput
            WriteLine("{0} inches is {1} centimeters", inches, total);
        }
    }
}
