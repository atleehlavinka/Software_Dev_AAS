using System;
using static System.Console;
namespace LectureOverLoadAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            TryThis obj1 = new TryThis();
            obj1.Num1 = 10;
            obj1.Str1 = "SWDV125";
            TryThis obj2 = new TryThis();
            obj2.Num1 = 40;
            obj2.Str1 = " Intermediate Programming";
            TryThis obj3 = new TryThis();
            obj3 = obj1 + obj2;

            WriteLine("{0} {1}", obj3.Num1, obj3.Str1);

            TryThis returnNeg = new TryThis();
            returnNeg = -obj1;
            WriteLine("{0} {1}", returnNeg.Num1, returnNeg.Str1);
        }//end main
    }//end program
    class TryThis
    {
        public int Num1 { get; set; }
        public string Str1 { get; set; }

        public static TryThis operator+ (TryThis object1, TryThis object2)
        {
            TryThis objAdd = new TryThis();
            objAdd.Num1 = object1.Num1 + object2.Num1;
            objAdd.Str1 = object1.Str1 + object2.Str1;
            return objAdd;
        }//end overload +
        public static TryThis operator- (TryThis makeNegative)
        {
            makeNegative.Num1 = -makeNegative.Num1;
            return makeNegative;
        }

    }//end TryThis
}
