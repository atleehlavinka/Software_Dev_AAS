// Program gets a quanity ordered from user
// then determines price and discount based on quantity
// price per item before discounts is $6.00
// order 15 or more, get a 20% discount
// order 10 to 14 - get a 14% discount
// order 5 to 9, get a 10% discount
using System;
using static System.Console;
class DebugSeven3
{
    static void Main()
    {
        int myQuantity = 0;
        double price = 0.00, returnPrice;
        int returnQuantity;
        returnQuantity = GetQuantity(myQuantity);
        returnPrice = CalculatePrice(price, Convert.ToDouble(returnQuantity));
        WriteLine("Final price for {0} items is {1}.", returnQuantity, returnPrice.ToString("c"));
    }
    private static int GetQuantity(int quantity)
    {
        int enteredQuantity;
        Write("Enter number of items >> ");
        enteredQuantity = Convert.ToInt32(ReadLine());
        return enteredQuantity;
    }
    private static double CalculatePrice(double price, double quantityOrdered)
    {
        double PRICE_PER_ITEM = 6.00;
        double myPrice = 0.00;
        double discount = 0;
        int[] quanLimits = { 0, 5, 10, 15 };
        double[] limits = { 0, 0.10, 0.14, 0.20 };
        for (int x = limits.Length - 1; x >= 0; --x)
            if (quantityOrdered >= quanLimits[x])
            {
                discount = limits[x];
                x = 0;
            }

        myPrice = quantityOrdered * PRICE_PER_ITEM;
        myPrice = myPrice - myPrice * discount;
        return myPrice;
    }
}