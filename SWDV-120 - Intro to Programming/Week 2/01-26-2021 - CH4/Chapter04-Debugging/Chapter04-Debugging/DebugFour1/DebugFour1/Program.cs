// Program takes a hot dog order
// And determines price
using System;
using static System.Console;
class DebugFour1
{
    static void Main()
    {
        const double BASIC_DOG_PRICE = 2.00;
        const double CHILI_PRICE = 0.69;
        const double CHEESE_PRICE = 0.49;
        string wantChili, wantCheese; //changed 'String' to 'string'
        double price;
        int number = 0;

        do
        {
            Write("Do you want chili on your dog? ");
            wantChili = ReadLine(); //corrected variable name extra 'l' in Chili

            Write("Do you want cheese on your dog? ");
            wantCheese = ReadLine();

            if (wantChili == "Y" || wantChili == "y") //Updated = to '==' (comparison)
                if (wantCheese == "Y" || wantCheese == "y") //Updated '=' to '==' (comparison)
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE; //Updated '==' to '=' (set variable)
                else
                    price = BASIC_DOG_PRICE + CHILI_PRICE; //Updated == to = (set variable)
            else
               if (wantCheese == "Y" || wantCheese == "y") //Updated '=' to '==' (comparison)
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
            else
                price = BASIC_DOG_PRICE; //Updated '==' to '=' (set variable)
            WriteLine("Your total is {0}\n", price.ToString("C"));
            number++;
        } while (number < 5);
    }
}
