// Defines a base class named Letter
// And a child class CertifiedLetter who receives a discount
// Main program demonstrates a Letter of each type
using static System.Console;
class JobDemo
{
    static void Main()
    {
        Job job1 = new Job(111, "Smith", "exterior paint", 20);
        Job job2 = new Job(222, "Vega", "gutter clean", 4);
        Job job3 = new Job(111, "Land", "blacktop drive", 10);

        WriteLine(job1.ToString());
        WriteLine(job2.ToString());
        WriteLine(job3.ToString());

    }
    class Job
    {
        public const double RATE = 45.00;
        public double price;
        public int JobNumber { get; set; }
        public string Account { get; set; }
        public string JobType { get; set; }
        public int JobHours { get; set; }

        public Job(int jobNumber, string account, string jobType, int jobHours)
        {
            JobNumber = jobNumber;
            Account = account;
            JobType = jobType;
            JobHours = jobHours;
            price = jobHours * RATE;

        }
        public override string ToString()
        {
            string jobList = "Job " + JobNumber + " " + Account + " " + JobType + " " + JobHours + " hours @" + RATE.ToString("C2") + " per hour. Total price is " + price.ToString("C2");
            return jobList;
        }
    }
}