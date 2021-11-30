using System;
using static System.Console;
namespace TestFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight myFlight = new Flight();
            string num;
            WriteLine("Please enter your flight: ");
            myFlight.AirlineName = ReadLine();

            WriteLine("Please enter your flight number: ");
            myFlight.FlightNum = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your row number: ");
            myFlight.Row = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your seat number: ");
            myFlight.Seat = Convert.ToChar(ReadLine());

            WriteLine("The flight is #{0} on {1} Airlines.", myFlight.FlightNum, myFlight.AirlineName);
            WriteLine("Row {0} Seat {1}", myFlight.Row, myFlight.Seat);
        }
    }

    class Flight
    {
        public string AirlineName { get; set; }
        public int FlightNum { get; set; }
        public int Row { get; set; }
        public char Seat { get; set; }
    }
}
