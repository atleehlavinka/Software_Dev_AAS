using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoOverLoadAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            TryThis obj1 = new TryThis();
            obj1.Num1 = 10;
            obj1.Str1 = "SWDV110";

            TryThis obj2 = new TryThis();
            obj2.Num1 = 40;
            obj2.Str1 = "Intermediate Programming";

            TryThis obj3 = new TryThis();
            obj3 = obj1 + obj2;

            WriteLine("{0} {1}", obj3.Num1, obj3.Str1);

            TryThis returnNeg = new TryThis();
            returnNeg = -obj1;
            WriteLine("{0} {1}", returnNeg.Num1, returnNeg.Str1);
        }
    }//end program class

    class TryThis
    {
        public int Num1 { get; set; }
        public string Str1 { get; set; }
        public static TryThis operator+(TryThis obj1, TryThis obj2)
        {
            TryThis objAdd = new TryThis();
            objAdd.Num1 = obj1.Num1 + obj2.Num1;
            objAdd.Str1 = obj1.Str1 + obj2.Str1;

            return obj1;
        }
        public static TryThis operator-(TryThis negativeObj)
        {
            negativeObj.Num1 = -negativeObj.Num1;
            return negativeObj;
        }

    }//end TryThis class
}
