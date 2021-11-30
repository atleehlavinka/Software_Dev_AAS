using System;
using static System.Console;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterWord, newWord;
            string firstLetter, restOfWord;
            int wordLength;
            //int number = 0;

            //do
            //{
                Write("Enter a word ");
                enterWord = ReadLine();

                wordLength = enterWord.Length;

                firstLetter = enterWord.Substring(0, 1);
                restOfWord = enterWord.Substring(1, wordLength - 1);

                newWord = restOfWord + firstLetter + "ay";

                WriteLine("The pig Latin version is {0}", newWord);
            //    number = number + 1;
            //} while (number < 5);
        }
    }
}
