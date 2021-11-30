// String Demo
// Using Data Strings page 76 - 80
// 

using System;
using static System.Console;

class DemoStrings
{
    static void Main()
    {
        string enterWord, newWord;
        int wordLength;

        Write("Enter a three character word to see it in reverse order: ");
        enterWord = ReadLine();

        wordLength = enterWord.Length;
        WriteLine("\nThe length is: {0} ", wordLength);

        //variableName.Substring( ?, ?)
        //What is the starting position?
        //How many characters do I want?
        WriteLine("\nHere is each character in the word: ");
        WriteLine("The letter is: {0}", enterWord.Substring(0, 1));
        WriteLine("The letter is: {0}", enterWord.Substring(1, 1));
        WriteLine("The letter is: {0}", enterWord.Substring(2, 1));


        // Using an equation to answer --> What is the starting position?
        // equation must evaluate to an integer
        WriteLine("\nGet a position with an equation: ");
        WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 3, 1));
        WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 2, 1));
        WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 1, 1));

        newWord = enterWord.Substring(wordLength - 1, 1) + enterWord.Substring(wordLength - 2, 1) + enterWord.Substring(wordLength - 3, 1);

        WriteLine("\nThe original word was {0}. In reverse order, the word is {1}", enterWord, newWord);

    }
}