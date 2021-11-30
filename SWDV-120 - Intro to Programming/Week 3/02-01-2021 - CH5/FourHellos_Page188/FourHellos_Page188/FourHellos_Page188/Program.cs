using System;
using static System.Console;
class FourHellos
{
    static void Main()
    {
        int number = 1;
        const int LIMIT = 5;
        while (number < LIMIT)
        {
            WriteLine("Hello");
            //WriteLine("Enter in a number: ");
            number = number + 1;
        }
    }
}
