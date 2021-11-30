/*
 * C# Program to Accept the Height of a Person & Categorize as 
 * Tall, Average or Dwarf
 * Step 1: Correct the syntax errors
 * Step 2: Add a while loop using a sentinel value of 999 to exit the program
 */
using System;
using static System.Console;
class program
{
    public static void Main()
    {
        float height;
        WriteLine("Enter the height (in centimeters): ");
        height = int.Parse(Console.ReadLine());

        if (height < 150.0)
            WriteLine("Dwarf\n");
        else if (height >= 150.0 && height <= 165.0)
            WriteLine(" Average Height\n");
        else if (height >= 165.0 && height <= 195.0)
            WriteLine("Taller\n");
        else
            WriteLine("Abnormal height\n");

    }
}