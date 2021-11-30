using System;
using static System.Console;

namespace ClassDemoNOTandSHORTCIRCUIT
{
    class Program
    {
        static void Main(string[] args)
        {
    // NOT operator, page 165
    // The condition is false (result is true).   
            bool result = true;
            if (!result)
            {
                WriteLine("The condition is true (result is false).");
            }
            else
            {
                WriteLine("The condition is false (result is true).");
            }

            int m = 9;
            int n = 7;
            int p = 5;
            // AND and NOT, Truth Table page 151 
            if (m >= n && !(p > m))
              //9 >= 7 && !(5 >= 9))
             // T && !F
            {
                WriteLine("\n Not and AND");
                WriteLine("Nothing is larger than m.");
            }

     // NOT and OR, Truth Table page 152  
            m = 4;
            if (!(m >= n || m >= p))
             // !(4 >= 7 || 4 >= 5)
             // !(F || F)
            {
                WriteLine("\n Not and Or");
                WriteLine("Now m is the smallest.");
            }

    //This example will crash because both parts of the conditional expression will be evaluated even if a is null.
    //Boolean Logical Operators, page 153
    //https://help.semmle.com/wiki/display/CSHARP/Potentially+dangerous+use+of+non-short-circuit+logic
            /*  string a = null;
              if (a != null & a.ToLower() == "hello world")
              {
                 WriteLine("The string said hello world.");
              }*/
     
    //The example is easily fixed by using the short circuit AND operator. 
    //The program produces no output but does not crash, unlike the previous example.
            string a = null;
            if (a != null && a.ToLower() == "hello world")
            {
                WriteLine("The string said hello world.");
            }


        }
    }
}
