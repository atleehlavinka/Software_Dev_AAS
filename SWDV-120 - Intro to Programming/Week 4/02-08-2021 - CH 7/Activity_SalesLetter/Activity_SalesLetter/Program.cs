using System;
using static System.Console;
namespace Activity_SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WriteLine("From");
            DispayContractInfo();
            WriteLine("_______________________________________\n");
            WriteLine("Dear Client");
            WriteLine("We want to provide you good service.");
            WriteLine("Feel free to contact us at any time.");
            WriteLine("Looking forward to a long relationship.");
            WriteLine("_______________________________________\n");
            */
            DispayContractInfo();
            int passMeBaby = 55;
            double comingAtYou;
            comingAtYou = ReviewChapter7(passMeBaby);
            WriteLine("catchMeHere: {0}", comingAtYou);
        }
        //page 269, Figure 7-2
        private static void DispayContractInfo()
        {
            WriteLine("C# Company");
            WriteLine("Phone: 555 - 1234     Cell: 555 - 0912");
            WriteLine("Email: csharpcompany @csharp.com");
            WriteLine("On the Web at www.csharpcompanyforyou.com");
        }
        static double ReviewChapter7(int passMeBaby)
        {
            int imHereAlone = passMeBaby;
            double comingAtYou = 1.22;
            WriteLine("imHereAlone: {0}", imHereAlone);
            return comingAtYou;
        }
    }
}
