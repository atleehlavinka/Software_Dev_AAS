/*Created By: Atlee Hlavinka
**Description: User enters a numeric high school GPA and an admissions test score.
**Display the message Accept if the student meets either of the following requirements:
**  - A GPA of 3.0 or higher, and an admission test score of at least 60.
**  - A GPA of less than 3.0, and an admission test score of at least 80.
**  - If neither conditions are met, then display Reject.*/

using System;
using static System.Console;
namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            const double admissableGPA = 3.00;
            const int highTestScore = 80;
            const int lowTestScore = 60;
            double enterGPA;
            int enterTestScore;
            int number = 0;

            WriteLine("Your GPA must be 3.0 or higher, as well as having a test score of 60.");
            WriteLine("If your GPA is below 3.0, then your test score must be 80 or higher.");

            do
            {
                Write("Enter your High School GPA: ");
                enterGPA = Convert.ToDouble(ReadLine());

                Write("Enter your admission test score: ");
                enterTestScore = Convert.ToInt32(ReadLine());

                if (enterGPA >= admissableGPA)
                {
                    if (enterTestScore >= lowTestScore)
                        WriteLine("Accepted!  Your GPA and Test Score meets our requirements.");
                    else
                        WriteLine("Rejected. Your test score does not meet our requirements.");
                }
                else if (enterTestScore >= highTestScore)
                    WriteLine("Accepted! Your Test Score meets our requirements.");
                else
                    WriteLine("Rejected. Neither your GPA or Test Score meets our requirements.");
                Write("\n");
                number++;
            } while (number < 8);
        }
    }
}
