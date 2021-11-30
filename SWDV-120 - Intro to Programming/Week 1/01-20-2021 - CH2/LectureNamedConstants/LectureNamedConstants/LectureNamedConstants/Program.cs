using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace LectureNamedConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.06;
            double drive, headphone, total;
            //double drive;
            //double headphone;
            //double total;

            drive = 50;
            headphone = 80;

            total = drive + (drive * TAX_RATE);
            WriteLine("The {0} cost of an external {1} drive is {0}", total.ToString("C"), headphone);

            total = headphone + (headphone * TAX_RATE);
            WriteLine("The cost of Skullcandy headphones is {0}", total.ToString("C"));

        }
    }
}
