/*Created By: Atlee Hlavinka
**Description: Accepts a user's message and determines whether it is short enough for a social networking 
**service that does not accept messages of more than 14 characters.*/

using System;
using static System.Console;
namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tweetLength = 14;
            int newTweetLength;
            string twitterMessage;

            WriteLine("Twitter accepts posts that do not exceed 14 characters.\nEnter the phrase that you would like to post on Twitter:");
            twitterMessage = ReadLine();
            newTweetLength = twitterMessage.Length;

            if (newTweetLength <= tweetLength)
                WriteLine("Your phrase contains {0} characters. You can post your phrase: {1}", newTweetLength, twitterMessage);
            else
                WriteLine("Your phrase contains {0} characters. You cannot post. Reduce the number of characters to less than {1}", newTweetLength, tweetLength);


        }
    }
}
