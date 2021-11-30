// This program tells the user the values of the integers that are
// one more and one less than the entered integer
using System;
using static System.Console;
namespace DebugTwo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            int enteredInteger;
            int more, less;

            Write("Enter an integer >> ");
            entry = ReadLine();

            WriteLine("You entered {0}", entry);
            enteredInteger = Convert.ToInt32(entry); //spelled enteredInterger correctly

            more = enteredInteger + 1;
            less = enteredInteger - 1;

            WriteLine("One more than {0} is {1} and one less than {0} is {2}", enteredInteger, more, less);//added ",", changed placeholders from 1234 to 0102
            //, and added curly brackets around the first placeholder
        }
    }
}
