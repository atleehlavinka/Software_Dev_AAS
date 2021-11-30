using System;
using static System.Console;

namespace Lecture_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterWord, newWord;
            string firstLetter, lastLetter, middleWord;
            int wordLength, number = 0;

            do
            {
                Write("Enter a Word: ");
                enterWord = ReadLine();

                wordLength = enterWord.Length;

                firstLetter = enterWord.Substring(0, 1);
                lastLetter = enterWord.Substring(wordLength - 1, 1);
                middleWord = enterWord.Substring(1, wordLength - 2);

                newWord = lastLetter + middleWord + firstLetter;

                WriteLine("The new word is: {0}", newWord);
                number = number + 1;
            } while (number < 3);

//string enterWord, newWord;
//string firstLetter, lastLetter, middleWord;
//int wordLength, number = 0;

//do
//{
//Write("Enter a Word: ");
//enterWord = ReadLine();

//wordLength = enterWord.Length;

//firstLetter = enterWord.Substring(0, 1);
//lastLetter = enterWord.Substring(wordLength - 1, 1);
//middleWord = enterWord.Substring(1, wordLength - 2);

//newWord = lastLetter + middleWord + firstLetter;

//WriteLine("The new word is: {0}", newWord);
//number = number + 1;
//} while (number < 3);





        }
    }
}
