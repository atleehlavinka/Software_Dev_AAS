// Program compares your name to the name of your boss
using System;
using static System.Console;
namespace DebugTwo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bossName;
            bool areNamesTheSame;

            WriteLine("Enter your name >> "); //added "
            name = ReadLine();

            WriteLine("Hello {0}! Enter the name of your boss >> ", name);
            bossName = ReadLine(); //Deleted extra =

            areNamesTheSame = String.Equals(name, bossName);
            WriteLine("It is {0} that you are your own boss", areNamesTheSame); //Spelled areNamesTheSame correctly
        }
    }
}
