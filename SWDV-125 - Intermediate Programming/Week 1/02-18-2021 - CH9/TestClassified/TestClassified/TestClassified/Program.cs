//Read Exercise 2, page 415

//Price is a readonly property
//How to do a Readonly property, page 363

//Price needs to be calculated in the class definition for the object
//How to calculate price  
//Option 1 --> Reference You Do It, page 369 value set with mathmatical calculation
//Option 2 --> Reference Figure 9-14, page 372 instance method call from an accessor 
using System;
using static System.Console;
public class TestClassifiedAd
{
    public static void Main()
    {
        //page 358
        //create myClassifiedAd object
        ClassifiedAd myClassifiedAd = new ClassifiedAd();
        //create yourClassifiedAd object
        ClassifiedAd yourClassifiedAd = new ClassifiedAd();

        myClassifiedAd.Category = "Used cars";
        myClassifiedAd.Words = 100;
        DisplayAd(myClassifiedAd);

        yourClassifiedAd.Category = "Help wanted";
        yourClassifiedAd.Words = 60;
        DisplayAd(yourClassifiedAd);
    }//end Main

    static void DisplayAd(ClassifiedAd clad)
    //page 360
    {
        WriteLine("The classified ad with {0} words in category {1} costs {2}", clad.Words, clad.Category, clad.Price.ToString("C"));
    }//end DisplayAd
}
class ClassifiedAd
{
    const double PRICE_PER_WORD = 0.09;
    private int words;
    private double price;
    public string Category { get; set; }
    public int Words
    {
        get
        {
            return words;
        }
        set
        {
            words = value;
            price = words * PRICE_PER_WORD;
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
    }
}
