using System;
using static System.Console;
class CookieDemo2
{
    static void Main()
    {
        CookieOrder[] order = new CookieOrder[3];

        //based on DebugEleven04    
        bool areNumbersGood = false;
        int orderIn = 0;

        while ((!areNumbersGood) || (orderIn < order.Length))
        {
            try
            {
                GetOrder(out int getNumber, out string storeName, out string type, out int getDozen);
                order[orderIn] = new CookieOrder(getNumber, storeName, type, getDozen);
                areNumbersGood = true;
                WriteLine(order[orderIn].ToString());
                orderIn++;
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
                WriteLine("\t** The order number or dozen ordered was not a numeric value **");
                WriteLine("\tYou will have to re-enter the order.");
            }

        }// end while/

    } //end main
    public static void GetOrder(out int getNumber, out string storeName, out string type, out int getDozen)
    {
        try
        {
            Write("\nEnter the order number: ");
            getNumber = Convert.ToInt32(ReadLine());
            Write("Enter the store to fulfill the order: ");
            storeName = ReadLine();
            Write("What type of cookie is being ordered: ");
            type = ReadLine();
            Write("How many dozen? ");
            getDozen = Convert.ToInt32(ReadLine());
        }
        catch (FormatException fe)
        {
            throw (fe);
        }

    }//end getOrder
}

class CookieOrder
{
    public int OrderNum { get; set; }
    public string Name { get; set; }
    public string CookieType { get; set; }
    protected int dozens;
    public const int LOWPRICE = 13;
    public const int HIGHPRICE = 15;
    public const int CUTOFF = 2;
    public double Price { get; set; }
    public virtual int Dozens
    {
        get
        {
            return dozens;
        }
        set
        {
            dozens = value;
            if (dozens <= CUTOFF)
                Price = dozens * HIGHPRICE;
            else
                Price = CUTOFF * HIGHPRICE + (dozens - CUTOFF) * LOWPRICE;
        }
    }
    //parameterless constructor
    public CookieOrder()
    {
    }
    //constructor
    public CookieOrder(int getNumber, string storeName, string type, int getDozen)
    {
        OrderNum = getNumber;
        Name = storeName;
        CookieType = type;
        Dozens = getDozen;
    }
    public override string ToString()
    {
        return ("\n Order Number: " + OrderNum + " for " + Name + "\n " + CookieType +
                "\n How many dozen: " + Dozens + "\n Total Price: " + Price.ToString("C"));
    }
}

