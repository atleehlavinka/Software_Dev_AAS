using System;
using static System.Console;
class InputMethodDemo
{
    static void Main()
    {
        //if use new feature of C# 7.0 NOT required --> int first, second;
        int first, second;
        InputMethod(out first, out second); // use of out

        //new feature of C# 7.0, page 313
        //InputMethod(out int first, out int second);

        Write("After InputMethod first is {0}", first);
        WriteLine(" and second is {0}", second);
    }
    private static void InputMethod(out int one, out int two)
    // notice use of out
    {
        string s1, s2;
        Write("Enter first integer ");
        s1 = ReadLine();
        Write("Enter second integer ");
        s2 = ReadLine();
        one = Convert.ToInt32(s1);
        two = Convert.ToInt32(s2);
    }
}
