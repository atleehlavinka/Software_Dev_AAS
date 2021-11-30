using System;
using static System.Console;
namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            const int DOZEN = 12;
            string firstChicken, secondChicken, thirdChicken, fourthChicken;
            int calcFirst, calcSecond, calcThird, calcFourth, total, dozen, leftOver;

            //Input First Chicken's Eggs
            Write("Enter eggs for first chicken ");
            firstChicken = ReadLine();
            calcFirst = Convert.ToInt16(firstChicken);

            //Inpuit Second Chicken's Eggs
            Write("Enter eggs for second chicken ");
            secondChicken = ReadLine();
            calcSecond = Convert.ToInt16(secondChicken);

            //Input Third Chicken's Eggs
            Write("Enter eggs for third chicken ");
            thirdChicken = ReadLine();
            calcThird = Convert.ToInt16(thirdChicken);

            //Input Fourth Chicken's Eggs
            Write("Enter eggs for fourth chicken ");
            fourthChicken = ReadLine();
            calcFourth = Convert.ToInt16(fourthChicken);

            //Calculations
            total = calcFirst + calcSecond + calcThird + calcFourth;
            dozen = total / DOZEN;
            leftOver = total % DOZEN;

            //Output
            WriteLine("{0} eggs is {1} dozen with {2} left over", total, dozen, leftOver);
        }
    }
}
