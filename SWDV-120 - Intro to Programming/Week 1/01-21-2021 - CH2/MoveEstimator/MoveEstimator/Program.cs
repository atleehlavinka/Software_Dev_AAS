using System;
using static System.Console;
namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            const double HOURLY = 150;
            const double RATE_PER_MILE = 2;
            const double BASE = 200;
            string enterHours, enterMiles;
            double calcHours, calcMiles, estimate;

            //Input Hours
            Write("Please enter the estimated number of hours: ");
            enterHours = ReadLine();
            calcHours = Convert.ToDouble(enterHours);

            //Input Miles
            Write("How many miles involved in the move? ");
            enterMiles = ReadLine();
            calcMiles = Convert.ToDouble(enterMiles);

            //Calculation
            estimate = (BASE + (calcHours * HOURLY) + (calcMiles * RATE_PER_MILE));

            //Output
            WriteLine("For a move taking {0} hours and going {1} miles\n\tthe estimate is {2}", calcHours, calcMiles, estimate.ToString("C"));
            
        }
    }
}
