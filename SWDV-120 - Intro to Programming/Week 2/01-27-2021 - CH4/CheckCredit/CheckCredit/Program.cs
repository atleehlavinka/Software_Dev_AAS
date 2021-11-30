/*Created By: Atlee Hlavinka
**Description: Program prompts users to enter a purchase price for an item.
**If the value entered is greater than a credit limit of $5,000.00, display
**an error message; otherwise, display Approved.*/

using System;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            const double creditLimit = 5000.00;
            double enterCredit;
            
            WriteLine("Enter the purchase price of the item:");
            enterCredit = Convert.ToDouble(ReadLine());

            while (enterCredit != 9999.99)
            {
                if (enterCredit <= creditLimit)
                    WriteLine("Congratulations. You can purchase this item for {0}", enterCredit.ToString("C"));
                else
                    WriteLine("{0} credit limit exceeded. You cannot purchase this item!", creditLimit.ToString("C"));
            }
        }
    }
}
