// Creates a BoatLicense class
// And instantiates three BoatLicense objects
// The price of a licence is $25 if the boat motor is 50 HP or under
// and $38 if the HP is over 50
// Boat licenses are issued with numbers starting with 201601
using System;
using static System.Console;
using static System.Array;
class ConferenceLab
{
    static void Main()
    {
        Conference[] conference = new Conference[3];
        int x;

        for (x = 0; x < conference.Length; ++x)
        {
            conference[x] = new Conference();
            Write("Enter conference group name ");
            conference[x].EventLocation = ReadLine();
            Write("Enter conference starting date ");
            conference[x].Date = Convert.ToString(ReadLine());
            Write("Enter attendees ");
            conference[x].Attendees = Convert.ToInt32(ReadLine());
        }


        Sort(conference);
        WriteLine("Sorted conferences:");
        for (x = 0; x < conference.Length; ++x)
            Display(conference[x]);
        
    }
    internal static void Display(Conference con)
    {
        
        WriteLine("{0} Conference starts on {1} and has {2} attendees", con.EventLocation, con.Date, con.Attendees);
    }
}
class Conference : IComparable
{
    private string eventLocation;
    private string date;
    private int attendees;
    public string EventLocation
    {
        get
        {
            return eventLocation;
        }
        set
        {
            eventLocation = value;
        }
    }
    public string Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
        }
    }
    public int Attendees
    {
        get
        {
            return attendees;
        }
        set
        {
            attendees = value;
        }
    }

    int IComparable.CompareTo(Object o)
    {
        int returnVal;
        Conference temp = (Conference)o;
        if (this.Attendees > temp.Attendees)
            returnVal = 1;
        else if (this.Attendees < temp.Attendees)
            returnVal = -1;
        else
            returnVal = 0;
        return returnVal;
    }
}
