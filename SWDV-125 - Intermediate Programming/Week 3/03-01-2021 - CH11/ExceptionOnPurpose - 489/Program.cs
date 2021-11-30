using System;
using static System.Console;
class ExceptionsOnPurpose
{
    static void Main()
    {
        int answer;
        int result;
        int zero = 0;
        Write("Enter an integer >> ");
        answer = Convert.ToInt32(ReadLine());
        result = answer / zero;
        WriteLine("The answer is " + answer);
    }
}
