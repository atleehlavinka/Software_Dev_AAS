// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
class DebugEight2
{
    static void Main()
    {
        int numericScore = 82;
        string letterScore = "B";
        WriteLine("Score was {0}. ", numericScore);
        GiveBonus(ref numericScore);
        WriteLine("Now it is {0}.", numericScore);
        WriteLine("Grade was {0}", letterScore);
        GiveBonus(ref letterScore);
        WriteLine("Now it is {0}", letterScore);
    }
    private static void GiveBonus(ref int testScore)
    {
        const int BONUS = 5;
        testScore += BONUS;
    }
    private static void GiveBonus(ref string letterScore)
    {
        const string BONUS = "+";
        letterScore += BONUS;
    }
}



