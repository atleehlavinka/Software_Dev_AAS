using System;
using static System.Console;
public class ShirtDemo
{
    static void Main(string[] args)
    {
        //Shirt womanShirt = new Shirt("Women", "Cotton", "Purple", "Small");
        //Shirt runnerShirt = new Shirt("Running","Athletic Knit","Blue","Medium");
        //Shirt menShirt = new Shirt("Men","Moisture Wick","Black","X-Large");

        Shirt womanShirt = new Shirt();
        Shirt runnerShirt = new Shirt("Athletic Knit", "Blue");
        Shirt menShirt = new Shirt("Black");

        Display(womanShirt);
        Display(runnerShirt);
        Display(menShirt);
    }
    static void Display(Shirt sh)
    {
        WriteLine("TShirt for {0}: {1} fabric, Color: {2}, Size: {3}",sh.Category, sh.Fabric, sh.Color, sh.Size);
    }
}
public class Shirt
{
    //private string category;
    //private string fabric;
    //private string color;
    //private string size;

    public string Category { get; set; }
    public string Fabric { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }

    public Shirt(string category, string fabric, string color, string size)
    {
        Category = category;
        Fabric = fabric;
        Color = color;
        Size = size;
    }

    public Shirt()
    {
        Category = "Women";
        Fabric = "Cotton";
        Color = "Purple";
        Size = "Small";
    }

    public Shirt(string fabric, string color)
    {
        Category = "Running";
        Fabric = fabric;
        Color = color;
        Size = "Medium";
    }
    public Shirt(string color)
    {
        Category = "Men";
        Fabric = "Moisture Wick";
        Color = color;
        Size = "X-Large";
    }


}
