// This program computes net weekly pay
// based on hours worked, rate per hour,
// and 15% withholding
using System;
using static System.Console;
namespace DebugTwo3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double WITHHOLDING_RATE = 0.15; //changed from 15 to 0.15
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;

            Write("Enter the number of hours you worked this week >> ");
            hoursAsString = ReadLine(); //Spelled hoursAsString correctly

            Write("Enter your hourly rate >> ");
            rateAsString = ReadLine(); //Added ;

            hours = Convert.ToDouble(hoursAsString); //Spelled hoursAsString correctly
            rate = Convert.ToDouble(rateAsString); //Spelled rateAsString correctly

            gross = hours * rate; //changed to multiplication
            withholding = gross * WITHHOLDING_RATE;
            net = gross - withholding; //changed to  subtraction

            WriteLine("You worked {0} hours at {1} per hour",hours, rate.ToString("C"));
            WriteLine("Gross pay is {0}", gross.ToString("C"));
            WriteLine("Withholding is {0}", withholding.ToString("C"));
            WriteLine("Net pay is {0}", net.ToString("C")); Console.WriteLine("Hello World!"); //Added . between net and ToString
        }
    }
}
