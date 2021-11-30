using System;
using static System.Console;
namespace LectureCreditScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int CreditScore, total = 0, counter = 0;
            double average;
            WriteLine("Enter a credit score: ");
            CreditScore = Convert.ToInt32(ReadLine());

            while (CreditScore != 999)
            {
                if (CreditScore < 300 || CreditScore > 850)
                    WriteLine("Invalid Credit Score - Must be between 300 and 850");
                else
                {
                    total = total + CreditScore;
                    counter = counter + 1;
                }
                WriteLine("Enter a credit score or 999 to exit: ");
                CreditScore = Convert.ToInt32(ReadLine());
            }
            average = total / counter;
            WriteLine("The average credit score is: {0}", average.ToString("F2"));
        }
    }
}
