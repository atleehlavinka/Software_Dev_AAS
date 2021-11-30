using System;
using static System.Console;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;

            Write("Enter length of the room: ");
            length = int.Parse(ReadLine());

            Write("Enter width of the room: ");
            width = Convert.ToInt32(ReadLine());

            WriteLine("The cost for painting your room is: {0}", ComputeCost(length, width).ToString("c"));
        }
        static double ComputeCost(int length, int width)
        {
            const double PRICE = 16.20;
            double cost;
            cost = ((Double)(length)) * ((Double)(width)) * PRICE;
            return cost;

        }
    }
}
