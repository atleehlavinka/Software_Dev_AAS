using System;
using static System.Console;
namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            double enterGPA;
            int enterTestScore;

            WriteLine("Your GPA must be 3.0 or higher, as well as having a test score of 60.");
            WriteLine("If your GPA is below 3.0, then your test score must be 80 or higher.");

            Write("Enter your High School GPA: ");
            enterGPA = Convert.ToDouble(ReadLine());

            Write("Enter your admission test score: ");
            enterTestScore = Convert.ToInt32(ReadLine());

            ComputeAdmission(enterGPA, enterTestScore);
        }
        public static void ComputeAdmission(double enterGPA, int enterTestScore)
        {
            const double admissableGPA = 3.00;
            const int highTestScore = 80;
            const int lowTestScore = 60;

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
        }
    }
}
