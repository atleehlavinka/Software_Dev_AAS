using System;
using static System.Console;
using System.IO;
namespace ReadPatientRecords
{
    class Program
    {
        static void Main()
        {
            const char DELIM = ',';
            const string FILENAME = @"\\Remote-School\G\School\SWDV-125\Week 4\03-10-2021 - CH14\WritePatientRecords\WritePatientRecords\PatientData.txt";

            Patient pat = new Patient();
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            WriteLine("\n{0,-10}{1,-10}{2,-8}\n", "IdNumber", "Name", "Balance");
            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                pat.PatNum = Convert.ToInt32(fields[0]);
                pat.Name = fields[1];
                pat.Balance = Convert.ToInt32(fields[2]);
                WriteLine("{0,-10}{1,-10}{2,-8}", pat.PatNum, pat.Name, pat.Balance.ToString("C"));
                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }
    }

    public class Patient
    {
        private int patNum;
        private string name;
        private double balance;
        public int PatNum { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }
}
