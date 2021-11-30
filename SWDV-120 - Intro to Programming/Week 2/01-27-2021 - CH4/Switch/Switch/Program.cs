using System;
using static System.Console;
namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Enter year (1-4): ");
            year = Convert.ToInt32(ReadLine());

            switch(year)
            {
                case 1:
                    WriteLine("Freshman");
                    break;
                case 2:
                    WriteLine("Sophomore");
                    break;
                case 3:
                    WriteLine("Junior");
                    break;
                case 4:
                    WriteLine("Senior");
                    break;
                default:
                    WriteLine("Invalid Year");
                    break;
            }
        }
    }
}
