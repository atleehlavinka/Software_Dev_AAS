using System;
using static System.Console;
namespace AtleeHlavinkaGradeReport
{
    class ReportCard
    {
        static void Main()
        {
            GradeReport[] report = new GradeReport[3];
            int reportNum = 0;

            while (reportNum < report.Length)
            {
                try
                {
                    report[reportNum] = new GradeReport();
                    report[reportNum].setStuName();
                    report[reportNum].setMidGrade();
                    report[reportNum].setFinalGrade();
                    WriteLine(report[reportNum].ToString());
                    ++reportNum;
                }
                catch (FormatException e)
                {
                    WriteLine("\t** The midterm or final grade value was not a numeric value **");
                    WriteLine("\tYou will have to re-enter the student's grade information.\n");
                }
                catch (ArgumentException e)
                {
                    WriteLine("The value must be between 0 and 100\n");
                }
            }

        }
    }
    class GradeReport
    {
        public string StuName { get; set; }
        public double MidGrade { get; set; }
        public double FinalGrade { get; set; }

        public void setStuName()
        {
            try
            {
                Write("Enter the student's name: ");
                StuName = ReadLine();
            }
            catch (FormatException f)
            {
                throw (f);
            }

        }
        public void setMidGrade()
        {
            try
            {
                Write("Enter {0}'s midterm grade: ", StuName);
                MidGrade = Convert.ToDouble(ReadLine());
                try
                {
                    bool isGood;
                    isGood = DetermineGoodNum(MidGrade);
                }
                catch (ArgumentException e)
                {

                    throw (e);
                }
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }
        public void setFinalGrade()
        {
            try
            {
                Write("  Enter {0}'s final grade: ", StuName);
                FinalGrade = Convert.ToDouble(ReadLine());
                try
                {
                    bool isGood;
                    isGood = DetermineGoodNum(FinalGrade);
                }
                catch (ArgumentException e)
                {

                    throw (e);
                }
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }
        public string letterGrade;
        public string LetterGrade
        {
            get
            {
                double avgGrade = (FinalGrade + MidGrade) / 2;
                if (avgGrade > 90)
                    letterGrade = "A";
                else if (avgGrade > 80)
                    letterGrade = "B";
                else if (avgGrade > 70)
                    letterGrade = "C";
                else if (avgGrade > 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";
                return letterGrade;
            }
        }
        private static bool DetermineGoodNum(double MidGrade)
        {
            bool isGood;
            if (MidGrade >= 0 && MidGrade <= 100)
                isGood = true;
            else
                throw (new ArgumentException());
            return isGood;
        }
        public GradeReport()
        {
        }
        public GradeReport(string stuName, double midGrade, double finalGrade)
        {
            StuName = stuName;
            MidGrade = midGrade;
            FinalGrade = finalGrade;
        }
        public GradeReport(string stuName, double midGrade, double finalGrade, string letterGrade)
        {
            StuName = stuName;
            MidGrade = midGrade;
            FinalGrade = finalGrade;
            this.letterGrade = letterGrade;
        }
        public override string ToString()
        {
            return ("\n Grade Report for " + StuName + ", " + LetterGrade + "\n");
        }
    }
}


using System;
using static System.Console;
namespace AtleeHlavinkaGradeReport
{
    class ReportCard
    {
        static void Main()
        {
            GradeReport[] report = new GradeReport[3];
            int reportNum = 0;

            while (reportNum < report.Length)
            {
                try
                {
                    GetReport(out string stuName, out double midGrade, out double finalGrade);
                    report[reportNum] = new GradeReport(stuName, midGrade, finalGrade);
                    WriteLine(report[reportNum].ToString());
                    reportNum++;
                }
                catch (FormatException e)
                {
                    WriteLine("\t** The midterm or final grade value was not a numeric value **");
                    WriteLine("\tYou will have to re-enter the student's grade information.\n");
                }
                catch (ArgumentException e)
                {
                    WriteLine("The value must be between 0 and 100\n");
                }
            }

        }
        public static void GetReport(out string stuName, out double midGrade, out double finalGrade)
        {
            try
            {
                Write("Enter name: ");
                stuName = ReadLine();

                Write("Enter {0}'s midterm grade: ", stuName);
                midGrade = Convert.ToDouble(ReadLine());
                if (midGrade < 0 || midGrade > 100)
                    throw (new ArgumentException());

                Write("  Enter {0}'s final grade: ", stuName);
                finalGrade = Convert.ToDouble(ReadLine());
                if (finalGrade < 0 || finalGrade > 100)
                    throw (new ArgumentException());
            }
            catch (FormatException fe)
            {
                throw (fe);
            }
        }
    }



    class GradeReport
    {
        public string StuName { get; set; }
        public double MidGrade { get; set; }
        public double FinalGrade { get; set; }

        public string letterGrade;
        public string LetterGrade
        {
            get
            {
                double avgGrade = (FinalGrade + MidGrade) / 2;
                if (avgGrade > 90)
                    letterGrade = "A";
                else if (avgGrade > 80)
                    letterGrade = "B";
                else if (avgGrade > 70)
                    letterGrade = "C";
                else if (avgGrade > 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";
                return letterGrade;
            }
        }
        public GradeReport()
        {
        }
        public GradeReport(string stuName, double midGrade, double finalGrade)
        {
            StuName = stuName;
            MidGrade = midGrade;
            FinalGrade = finalGrade;
        }
        public GradeReport(string stuName, double midGrade, double finalGrade, string letterGrade)
        {
            StuName = stuName;
            MidGrade = midGrade;
            FinalGrade = finalGrade;
            this.letterGrade = letterGrade;
        }
        public override string ToString()
        {
            return ("\n Grade Report for " + StuName + ", " + LetterGrade + "\n");
        }
    }
}
