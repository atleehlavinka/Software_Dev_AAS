//Table 2-5 on page 74 describes some common escape sequences
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoEscapeSequencesPage74
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This is an example\n of a newline");

            WriteLine("This is an \t example \t of \t a \t horizontal \t tab");

            WriteLine("This is an example showing \r a carriage return");

            //https://msdn.microsoft.com/en-us/library/h21280bw.aspx
            WriteLine("This is an example of an alert \a .. bell sound ");
        }
    }
}
