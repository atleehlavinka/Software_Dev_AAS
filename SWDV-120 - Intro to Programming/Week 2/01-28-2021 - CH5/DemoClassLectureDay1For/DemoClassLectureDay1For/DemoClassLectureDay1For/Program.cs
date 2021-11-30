using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoClassLectureDay1For
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, result;
            Write("Enter a number\t");
            num = Convert.ToInt32(ReadLine());

            for (i = 1; i <= 10; i++)
            {
                result = num * i;
                WriteLine("{0} x {1} = {2}", num, i, result);
            }
        }
    }
}
