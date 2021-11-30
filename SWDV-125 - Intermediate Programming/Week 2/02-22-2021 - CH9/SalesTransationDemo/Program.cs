using System;
using static System.Console;
public class SalesTransaction
{
    static void Main()
    {
        Transaction houseTaylor = new Transaction("Taylor", 500000, .06);
        Transaction houseJones = new Transaction("Jones", 400000);
        Transaction houseBaxton = new Transaction("Baxton");

        Display(houseTaylor);
        Display(houseJones);
        Display(houseBaxton);

        Transaction addedTransactions;
        addedTransactions = houseTaylor + houseJones;
        WriteLine("Total: {0}", addedTransactions.Sales);
    }
    static void Display(Transaction tr)
    {
        WriteLine("Realtor: {0}\t Sales: {1}\t Rate: {2}\t Commission Amount: {3}", tr.Realtor, tr.Sales, tr.Rate, tr.Commission);
    }
}

public class Transaction
{
    public string Realtor { get; set; }
    public int Sales { get; set; }
    public double Rate { get; set; }
    public double Commission { get; set; }

    public Transaction(string realtor, int sales, double rate)
    {
        Realtor = realtor;
        Sales = sales;
        Rate = rate;
        Commission = sales * rate;
    }
    public Transaction(string realtor, int sales)
    {
        Realtor = realtor;
        Sales = sales;
        Rate = 0;
        Commission = 0;
    }
    public Transaction(string realtor)
    {
        Realtor = realtor;
        Sales = 0;
        Rate = 0;
        Commission = 0;
    }
    public Transaction(int sales)
    {
        Realtor = "";
        Sales = sales;
        Rate = 0;
        Commission = 0;
    }
    public static Transaction operator+ (Transaction first, Transaction second)
    {
        int addSales = first.Sales + second.Sales;
        return (new Transaction(addSales));
    }
}