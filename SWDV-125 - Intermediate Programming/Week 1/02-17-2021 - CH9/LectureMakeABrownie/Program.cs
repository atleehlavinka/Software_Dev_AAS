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
            }
        }
    }
    class Dessert
    {
        private double butter;
        private int sugar;
        private int vanilla;
        private int eggs;
        private double bakingPowder;
        private string flavor;
        private double salt;
        private double flour;

        public double Butter
        {
            get
            {
                return butter;
            }
            set
            {
                butter = value;
            }
        }

        public int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
            }
        }
        public int Vanilla
        {
            get
            {
                return vanilla;
            }
            set
            {
                vanilla = value;
            }
        }
        public int Eggs
        {
            get
            {
                return eggs;
            }
            set
            {
                eggs = value;
            }
        }
        public double BakingPowder
        {
            get
            {
                return bakingPowder;
            }
            set
            {
                bakingPowder = value;
            }
        }
        public string Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
        public double Salt
        {
            get
            {
                return salt;
            }
            set
            {
                salt = value;
            }
        }    
        public double Flour
        {
            get
            {
                return flour;
            }
            set
            {
                flour = value;
            }
        }

    }
}
