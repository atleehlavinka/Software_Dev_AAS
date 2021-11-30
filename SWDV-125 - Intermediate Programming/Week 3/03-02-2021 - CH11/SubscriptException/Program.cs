using System;
using static System.Console;
namespace SubscriptException
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double[] arr = { 20.3, 44.6, 32.5, 46.7, 89.6, 67.5, 12.3, 14.6, 22.1, 13.6 };
            int i = 0;
            int subvalue = 0;
            const int quit = 99;
            bool isAValue = true;
            Write("Array Values:\t");
            for (i = 0; i < arr.Length; ++i)
                Write(arr[i] + "\t");
            WriteLine("");
            while (!subvalue.Equals(quit))
            {
                Write("\nEnter a subscript value or {0} to quit >> ", quit);
                subvalue = Convert.ToInt32(ReadLine());

                try
                {
                    isAValue = DetermineValue(subvalue);
                    if (isAValue)
                        WriteLine("The value is " + arr[subvalue-1]);
                    //else
                    //    WriteLine("Index was outside the bounds of the array.");

                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    WriteLine(e.Message);
                }
                
            }
        }
        private static bool DetermineValue(int subvalue)
        {
            bool isAValue;

            if (subvalue < 11)
                isAValue = true;
            else if (subvalue == 99)
                isAValue = false;
            else
                throw (new IndexOutOfRangeException());
            return isAValue;
        }
    }
}
