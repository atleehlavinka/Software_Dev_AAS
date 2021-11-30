//do while loop same as while loop only differences between them is that, do while executes at least one time
using System;
using static System.Console;
namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int table, i, res;
            table = 12;
            i = 1;
            do
            {
                res = table * i;
                WriteLine("{0} x {1} = {2}", table, i, res);
                i++;
            }
            
            while (i <= 10);
            // must put semi-colon(;) at the end of while condition in do...while loop.
        }
    }
}
