using System;
using static System.Console;
namespace LectureMakeABrownie
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessert brownie = new Dessert();
            brownie.Butter = .5;
            brownie.Sugar = 1;
            brownie.Vanilla = 1;
            brownie.Eggs = 2;
            brownie.BakingPowder = .25;
            brownie.Flavor = "Chocolate";
            brownie.Salt = .25;
            brownie.Flour = .5;
            DisplayRecipe(brownie);

            Dessert creamCheese = new Dessert();
            creamCheese.Butter = .5;
            creamCheese.Sugar = 1;
            creamCheese.Vanilla = 1;
            creamCheese.Eggs = 2;
            creamCheese.BakingPowder = .25;
            creamCheese.Flavor = "Cream Cheese";
            creamCheese.Salt = .25;
            creamCheese.Flour = .5;
            DisplayRecipe(creamCheese);

            static void DisplayRecipe(Dessert typeOfBrownie)
            {
                WriteLine("To make a {0} brownie, you will need: ", typeOfBrownie.Flavor);
                WriteLine("{0} cup of butter", typeOfBrownie.Butter);
                WriteLine("{0} cup of sugar", typeOfBrownie.Sugar);
                WriteLine("{0} teaspoon vanilla", typeOfBrownie.Vanilla);
                WriteLine("{0} eggs", typeOfBrownie.Eggs);
                WriteLine("{0} teaspoon baking powder", typeOfBrownie.BakingPowder);
                WriteLine("{0} teaspoon salt", typeOfBrownie.Salt);
                WriteLine("{0} cup of flour", typeOfBrownie.Flour);
                WriteLine("");
            }
        }
    }
    class Dessert
    {
        public double Butter { get; set; }
        public int Sugar { get; set; }
        public int Vanilla { get; set; }
        public int Eggs { get; set; }
        public double BakingPowder { get; set; }
        public string Flavor { get; set; }
        public double Salt { get; set; }
        public double Flour { get; set; }

    }
}
