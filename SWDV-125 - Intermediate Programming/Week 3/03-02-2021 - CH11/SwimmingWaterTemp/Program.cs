using System;
using static System.Console;
namespace SwimmingWaterTemperature
{
    class Program
    {
        static void Main(string[] args)
        {

            int waterTemp = 0;
            const int quit = 0;
            bool isTemp;

            while (!waterTemp.Equals(quit))
            {
                Write("\nEnter temperature or {0} to quit >> ", quit);
                waterTemp = Convert.ToInt32(ReadLine());

                try
                {
                    isTemp = DetermineTemp(waterTemp);
                    if (isTemp)
                    {
                        if (waterTemp < 70)
                            WriteLine("{0} degress is not comfortable for swimming.", waterTemp);
                        else
                            WriteLine("{0} degress is comfortable for swimming.", waterTemp);
                    }
                    //isAValue = DetermineValue(subvalue);
                    //if (isAValue)
                    //    WriteLine("The value is " + arr[subvalue - 1]);
                    //else
                    //    WriteLine("Index was outside the bounds of the array.");

                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                }

            }
        }
        private static bool DetermineTemp(int waterTemp)
        {
            bool isTemp;

            if (waterTemp > 0 || waterTemp < 100)
                isTemp = true;
            else
                throw (new FormatException());
            return isTemp;
        }
    }
}
