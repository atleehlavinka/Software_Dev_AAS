using System;
using static System.Console;
namespace LectureLunchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch customer1 = new Lunch();
            Lunch customer2 = new Lunch("Pastrami Sandwich", "Chips");
            Lunch customer3 = new Lunch("A&W Root Beer");

            //WriteLine("{0, -20} {1, -20} {2, -20}", customer1.Entree, customer1.Drink, customer1.Side);
            //WriteLine("{0, -20} {1, -20} {2, -20}", customer2.Entree, customer2.Drink, customer2.Side);
            //WriteLine("{0, -20} {1, -20} {2, -20}", customer3.Entree, customer3.Drink, customer3.Side);
            DisplayOrder(1, customer1);
            DisplayOrder(2, customer2);
            DisplayOrder(3, customer3);
           
        }//end main 
        static void DisplayOrder(int num, Lunch customer)
        {
            WriteLine("Customer {0}: {1, -20} {2, -20} {3, -20}", num, customer.Entree, customer.Drink, customer.Side);
        }
    }//program
    class Lunch
    {
        //page 367, auto-implementation Figure 9-11
        public string Entree { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }
        // build constructors
        //CreateSomeEmployees on page 381 (constructors) and page 382
        //parameterless constructor
        public Lunch()
        {
            Entree = "Hamburger";
            Drink = "Cherry Pepsi";
            Side = "French Fries";
        }
        public Lunch(string entree, string side)
        {
            Entree = entree;
            Drink = "Milk";
            Side = side;
        }
        public Lunch(string drink)
        {
            Entree = "Pizza";
            Drink = drink;
            Side = "Salad";
        }
    }//end

}
