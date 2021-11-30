//This program demonstrates the example on page 80, Figure 2-19
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoStringPage80water
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringName = "winter";
            string breakItUp;

            breakItUp = stringName.Substring(1, 2);

            WriteLine("This section of the contains letters: {0}", breakItUp);

            //int totalLetters;
            //totalLetters = stringName.Length;
            //WriteLine("The string {0} contains {1} characters", stringName, totalLetters);

        }
    }
}
