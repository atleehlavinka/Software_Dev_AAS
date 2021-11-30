using System;
using static System.Console;
namespace DogBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PERPOUND = .5;
            string enterPounds, enterDays;
            double calcPounds, calcBoarding;
            int calcDays;

            Write("Enter how many pounds does your dog weigh: ");
            enterPounds = ReadLine();
            calcPounds = Convert.ToDouble(enterPounds);
            calcPounds = calcPounds * PERPOUND;

            Write("Enter the number of days that your dog will be boarded: ");
            enterDays = ReadLine();
            calcDays = Convert.ToInt16(enterDays);
            calcBoarding = calcDays * calcPounds;

            WriteLine("The total boarding cost for {0} days for a dog that weighs {1} pounds is {2}", calcDays, enterPounds, calcBoarding.ToString("C"));
        }
    }
}
