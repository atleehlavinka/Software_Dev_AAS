using static System.Console;
class CreateTwoBooks
{
    static void Main()
    {
        Book myBook = new Book();
        Book yourBook = new Book();
        myBook.Title = "Silas Marner";
        yourBook.Title = "The Time Traveler's Wife";
        myBook.SetPriceAndTax(12.99);
        yourBook.SetPriceAndTax(19.99);
        WriteLine("{0} costs {1}", myBook.Title, (myBook.Price + myBook.Tax).ToString("C"));
        WriteLine("{0} costs {1}", yourBook.Title, (yourBook.Price + yourBook.Tax).ToString("C"));
    }
}
class Book
{
    private double tax;
    private double price;
    public string Title { get; set;}
    public double Tax
    {
        get
        {
            return tax;
        }
        set
        {
            tax = value;
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public void SetPriceAndTax(double price)
    {
        const double TAX_RATE = .07;
        this.price = price;
        tax = price * TAX_RATE;
    }
}
