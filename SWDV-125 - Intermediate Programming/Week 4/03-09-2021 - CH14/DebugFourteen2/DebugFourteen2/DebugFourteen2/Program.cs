// Creates a Student file
using System;
using static System.Console;
using System.IO;
class DebugFourteen2
{
    static void Main()
    {
        const int END = 999;
        const string DELIM = ",";
//FILENAME = "C:\\Users\\User\\Downloads\\Chapter 14\\StudentData.txt"; <--- point to file location
//or 
//FILENAME = @"C:\Users\User\Downloads\Chapter 14\StudentData.txt"; <--- point to file location
        const string FILENAME = @"\\Remote-School\G\School\SWDV-125\Week 4\03-09-2021 - CH14\DebugFourteen2\DebugFourteen2\DebugFourteen2\bin\Debug\netcoreapp3.1\StudentData.txt";

        Student stu = new Student();
        FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        Write("Enter student number or " + END + " to quit ");
        stu.StuNum = Convert.ToInt32(ReadLine());

        while (stu.StuNum != END)
        {
            Write("Enter last name ");
            stu.Name = ReadLine();

            Write("Enter grade point average ");
           stu.Gpa = Convert.ToDouble(ReadLine());

            writer.WriteLine(stu.StuNum + DELIM + stu.Name + DELIM + stu.Gpa);
            Write("Enter next student number or " + END + " to quit ");
            stu.StuNum = Convert.ToInt32(ReadLine());
        }

        writer.Close();
        outFile.Close();
    }
}

public class Student
{
    private int stuNum;
    private string name;
    private double gpa;
    private const double MINGPA = 0.0;
    private const double MAXGPA = 4.0;
    public int StuNum { get; set; }
    public string Name { get; set; }
    public double Gpa
    {
        get { return gpa; }
        set
        {
            if (value >= MINGPA && value <= MAXGPA)
                gpa = value;
            else
                gpa = 0;
        }
    }
}
