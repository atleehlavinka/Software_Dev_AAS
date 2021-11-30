using System;
using static System.Console;
namespace LectureIQwithWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int UPPERIQ = 200, AVGIQ = 100;
            int numIQ;

            WriteLine("Enter the IQ quotient: ");
            numIQ = Convert.ToInt32(ReadLine());

            while (numIQ != 999)
            {
                if (numIQ != 999)

                    WriteLine("Error {0} is not a valid entry", numIQ);
                else
                    if (numIQ > AVGIQ)
                    WriteLine("An IQ of {0} is above average", numIQ);
                else
                    if (numIQ < AVGIQ)
                    WriteLine("An IQ of {0} is below average", numIQ);
                else
                    WriteLine("An IQ of {0} is average", numIQ);
                    WriteLine("Enter the IQ quotient or 999 to exit: ");
                numIQ = Convert.ToInt32(ReadLine());
            }
        }
    }
}
