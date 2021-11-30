using System;
using static System.Console;
using System.IO;
namespace WritePatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = @"\\Remote-School\G\School\SWDV-125\Week 4\03-10-2021 - CH14\WritePatientRecords\WritePatientRecords\PatientData.txt";

            Patient pat = new Patient();
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            Write("Enter patient ID number or " + END + " to quit >> ");
            pat.PatNum = Convert.ToInt32(ReadLine());

            while (pat.PatNum != END)
            {
                Write("Enter last name >> ");
                pat.Name = ReadLine();

                Write("Enter balance ");
                pat.Balance = Convert.ToInt32(ReadLine());

                writer.WriteLine(pat.PatNum + DELIM + pat.Name + DELIM + pat.Balance);
                Write("Enter patient ID number or " + END + " to quit >> ");
                pat.PatNum = Convert.ToInt32(ReadLine());
            }

            writer.Close();
            outFile.Close();
        }
    }
    public class Patient
    {
        private int patNum;
        private string name;
        private int balance;
        public int PatNum { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }
}
