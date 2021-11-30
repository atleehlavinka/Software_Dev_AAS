// Creates a Car class
// You can construct a Car using a price and color
// or just a price, in which case a Car is black
// or no parameters, in which case a Car is $10,000 and black
using static System.Console;
class FixedDebugNine3
{
    static void Main()
    {
        Car myCar = new Car(32000, "red");
        Car yourCar = new Car(14000);
        Car theirCar = new Car();
        WriteLine("My {0} car cost {1}", myCar.Color,
           myCar.Price.ToString("c2"));
        WriteLine("Your {0} car cost {1}",
           yourCar.Color, yourCar.Price.ToString("c2"));
        WriteLine("Their {0} car cost {1}",
           theirCar.Color, theirCar.Price.ToString("c2"));
    }
}
class Car
{
    private string color;
    private int price;
    public Car() : this(10000, "black")
    {
    }
    public Car(int price) : this(price, "black")
    {
    }
    public Car(int price, string color)
    {
        Price = price;
        Color = color;
    }
    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
    public int Price
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
}