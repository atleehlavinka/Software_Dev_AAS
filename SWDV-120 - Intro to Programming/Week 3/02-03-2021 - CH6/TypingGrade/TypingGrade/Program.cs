using System;
using static System.Console;
namespace TypingtypingGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxWPM = 250;
            int[] words =             { 0  , 15 , 40 , 60 , 75 };
            string[] typingGrade =    { "F", "D", "C", "B", "A"};
            int wordsPerMinute;
            string letterGrade;

            Write("Enter number of words typed: ");
            wordsPerMinute = Convert.ToInt32(ReadLine());

            for (int x = words.Length - 1; x >= 0; --x)
                if (wordsPerMinute >= words[x])
                {
                    letterGrade = typingGrade[x];
                    x = 0;
                    WriteLine("Typing {0} words per minute: Grade {1}", wordsPerMinute, letterGrade);
                }
        }
    }
}
