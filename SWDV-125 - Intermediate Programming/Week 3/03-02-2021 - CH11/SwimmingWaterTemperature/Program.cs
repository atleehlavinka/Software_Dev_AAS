using System;
using static System.Console;
namespace SwimmingWaterTemperature
{
    class Program
    {
        static void Main(string[] args)
        {

            int waterTemp = 0; 
            const int quit = 999;
            bool isTemp = false;

            while (!waterTemp.Equals(quit))
            {
                Write("\nEnter temperature or {0} to quit >> ", quit);
                waterTemp = Convert.ToInt32(ReadLine());

                try
                {
                    isTemp = DetermineTemp(waterTemp);
                    if (isTemp)
                    {
                        if (waterTemp < 70 || waterTemp > 85)
                            WriteLine("{0} degress is not comfortable for swimming.", waterTemp);
                        else
                            WriteLine("{0} degress is comfortable for swimming.", waterTemp);
                    }
                }
                catch (ArgumentException e)
                {
                    WriteLine(e.Message);
                    WriteLine("yano");
                }

            }
        }
        private static bool DetermineTemp(int waterTemp)
        {
            bool isTemp;

            if (waterTemp > 32 && waterTemp < 212)
                isTemp = true;
            else if (waterTemp == 999)
                isTemp = false;
            else
                throw (new ArgumentException());
            return isTemp;
        }
    }
}
