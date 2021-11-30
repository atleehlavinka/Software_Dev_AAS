using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoClassLectureDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, result, beginMultiply;

            WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(ReadLine());
            // num1 = int.Parse(ReadLine()); <--- different way; same result as line above

            beginMultiply = 1; //Initialization
            
            while (beginMultiply <= 10) //Check whether condition matches or not
            {
                result = num1 * beginMultiply;
                WriteLine("{0} x {1} = {2}", num1, beginMultiply, result);

                beginMultiply++; //Increment by one
            }
        }
    }
}
