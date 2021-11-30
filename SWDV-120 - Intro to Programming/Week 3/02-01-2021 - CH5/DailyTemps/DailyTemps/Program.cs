using System;
using static System.Console;
namespace DailyTemps
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sentinel = 999;
            int enterTemp, total = 0, counter = 0;
            double average;

            Write("Enter temperature >> ", sentinel);
            enterTemp = Convert.ToInt32(ReadLine());

            while (enterTemp != 999)
            {
                if (enterTemp < 0)
                    WriteLine("Temperature is too cold! Tempuratures must be between 0 and 99.");
                else if (enterTemp > 99)
                    WriteLine("Temperature is too hot! Tempuratures must be between 0 and 99.");
                else
                {
                    total = total + enterTemp;
                    counter++;
                }
                Write("Enter another temperature or {0} to quit >> ", sentinel);
                enterTemp = Convert.ToInt32(ReadLine());
            }
            
            average = Convert.ToDouble(total) / Convert.ToDouble(counter);
            WriteLine("The average of the {0} valid temperatures entered is: {1}", counter, average.ToString("F1"));
        }
    }
}
