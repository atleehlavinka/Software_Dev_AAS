using System;
using static System.Console;
namespace LectureSidingEstimateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int estimate;
            //string entryValue;
            Write("Enter the length of the house in feet: ");
            //entryValue = ReadLine();
            length = int.Parse(ReadLine());
            Write("Enter the width of the house in feet: ");
            width = Convert.ToInt32(ReadLine());
            //Option 1 how we can return information
            //estimate = ComputeCost(length, width);
            // WriteLine("Cost of siding is {0}", estimate.ToString("c"));
            //Option 2
            WriteLine("Cost of siding is {0}", ComputeCost(length, width).ToString("c"));
        }//end Main
        static int ComputeCost(int length, int width)
        {
            const int PRICE = 5;
            int cost;
            cost = length * width * PRICE;
            return cost;

        }//end ComputeCost
    }
}
