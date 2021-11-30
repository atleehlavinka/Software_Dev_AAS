using System;
using static System.Console;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0}","you");
            WriteLine("{0,5}", "you");
            WriteLine("{0,5}", 8);
            WriteLine("Your first number is {0,8}. Your next number is {1,2}.", 8, 2);
            
            float a = 33.5654f;
            WriteLine(a);
        }
    }
}
