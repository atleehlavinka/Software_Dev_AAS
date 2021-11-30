using System;
using static System.Console;
namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tweetLength = 14;
            const string sentinel = "exit";
            int newTweetLength;
            string twitterMessage;

            WriteLine("Twitter accepts posts that do not exceed 14 characters.\nEnter the phrase that you would like to post on Twitter:");
            twitterMessage = ReadLine();
            newTweetLength = twitterMessage.Length;


            while (twitterMessage != sentinel)
            {
                if (newTweetLength > tweetLength)
                    WriteLine("Your phrase contains {0} characters. You cannot post. Reduce the number of characters to {1} or less.", newTweetLength, tweetLength);
                else
                {
                    WriteLine("Your phrase contains {0} characters. You can post your phrase: {1}", newTweetLength, twitterMessage);
                }
                WriteLine("\nEnter another phrase that you would like to post on Twitter or enter \"exit\" to exit:");
                twitterMessage = ReadLine();
                newTweetLength = twitterMessage.Length;
            }
        }
    }
}