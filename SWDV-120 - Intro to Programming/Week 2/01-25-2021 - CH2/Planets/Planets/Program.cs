using System;
using static System.Console;

namespace Planets
{
    class Program
    {
        enum planets
        {Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune}
        static void Main(string[] args)
        {
            string enterPlanet;
            int planetNum;

            Write("Enter a number to see the planet at that position >> ");
            enterPlanet = ReadLine();
            planetNum = Convert.ToInt32(enterPlanet);

            WriteLine("You entered {0}", planetNum);

            WriteLine("{0} is {1} planet(s) from the sun",((planets)planetNum - 1), planetNum);

        }
    }
}
