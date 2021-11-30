using System;
using static System.Console;
class CompareThreeNumbers
{
    static void Main()
    {
        string numberString;
        int num1, num2, num3;
        int number = 0;

        do
        {
            Write("Enter an integer ");
            numberString = ReadLine();
            num1 = Convert.ToInt32(numberString);

            Write("Enter an integer ");
            numberString = ReadLine();
            num2 = Convert.ToInt32(numberString);

            Write("Enter an integer ");
            numberString = ReadLine();
            num3 = Convert.ToInt32(numberString);

            if (num1 == num2)
                if (num1 == num3)
                    WriteLine("All three numbers are equal\n");
                else
                    WriteLine("First two are equal\n");
            else
                if (num1 == num3)
                WriteLine("First and last are equal\n");
            else
                if (num2 == num3)
                WriteLine("Last two are equal\n");
            else
                WriteLine("No two numbers are equal\n");
            number++;
        } while (number < 5);
    }
        
}

