// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
namespace DebugTwo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string firstString, secondString; //Spelled secondString correctly
            int first, second, product;

            WriteLine("Enter your name >> "); //Added "    
            name = ReadLine(); //Added ()

            WriteLine("Hello, {0}! Enter an integer >> ", name);
            firstString = ReadLine();
            first = Convert.ToInt32(firstString); //Added . between Convert and ToInt32

            WriteLine("Enter another integer >> ");
            secondString = ReadLine(); //capitalized l in ReadLine
            second = Convert.ToInt32(secondString); //added 32 to ToInt32

            product = first * second;
            WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
           name, first, second, product); //Changed order of {0-3} to start at 0 and not 1
        }
    }
}
