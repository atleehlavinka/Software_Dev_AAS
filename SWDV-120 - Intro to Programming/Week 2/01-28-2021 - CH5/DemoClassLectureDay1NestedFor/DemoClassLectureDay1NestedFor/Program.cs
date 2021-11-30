using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoClassLectureDay1NestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 0;
            j = 0;

            for (i = 1; i < 3; i++)
            {
                WriteLine(" outside for loop");
                for (j = 1; j <= i; j++)
                {
                    Write("  inside for loop");
                    Write(i);
                }
                Write("\n");
            }
        }
    }
}
