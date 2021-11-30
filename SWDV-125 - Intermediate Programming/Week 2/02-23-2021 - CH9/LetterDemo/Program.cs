// Defines a base class named Letter
// And a child class CertifiedLetter who receives a discount
// Main program demonstrates a Letter of each type
using static System.Console;
class LetterDemo
{
    static void Main()
    {
        Letter Letter = new Letter();
        CertifiedLetter CertifiedLetter = new CertifiedLetter();

        Letter.LetterTo = "Electric Company";
        Letter.DateMailed = "02/14/16";
        CertifiedLetter.LetterTo = "Howe and Morris, LLC";
        CertifiedLetter.DateMailed = "04/01/2017";
        CertifiedLetter.TrackingNumber = "i2YD45";

        WriteLine("Letter To: {0} Date mailed : {1}", Letter.LetterTo, Letter.DateMailed);
        WriteLine("CertifiedLetter To: {0} Date mailed : {1} Tracking number: {2}", CertifiedLetter.LetterTo, CertifiedLetter.DateMailed, CertifiedLetter.TrackingNumber);
    }
    class Letter
    {
        public string LetterTo { get; set; }
        public string DateMailed { get; set; }
        public string TrackingNumber { get; set; }

        public Letter(string letterTo, string dateMailed, string trackingNumber)
        {
            LetterTo = letterTo;
            DateMailed = dateMailed;
            TrackingNumber = trackingNumber;

        }
        public Letter(string letterTo, string dateMailed)
        {
            LetterTo = letterTo;
            DateMailed = dateMailed;
        }
        public Letter(string dateMailed)
        {
            LetterTo = "";
            DateMailed = dateMailed;
        }
        public Letter()
        {

        }
    }

    class CertifiedLetter : Letter
    {
    }
}
