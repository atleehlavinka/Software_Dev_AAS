// Reads and displays a student file created in DebugFourteen2 program
using System;
using static System.Console;
using System.IO;
class FixedDebugFourteen3
{
    static void Main()
    {
        const char DELIM = ',';
//FILENAME = "C:\\Users\\User\\Downloads\\Chapter 14\\StudentData.txt"; <--- point to file location
//or 
//FILENAME = @"C:\Users\User\Downloads\Chapter 14\StudentData.txt"; <--- point to file location
        const string FILENAME = @"\\Remote-School\G\School\SWDV-125\Week 4\03-09-2021 - CH14\DebugFourteen2\DebugFourteen2\DebugFourteen2\bin\Debug\netcoreapp3.1\StudentData.txt";

        Student stu = new Student();
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);

        string recordIn;
        string[] fields;
        WriteLine("\n{0,-10}{1,-12}{2,8}\n", "Num", "Name", "GPA");
        recordIn = reader.ReadLine();

        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            stu.StuNum = Convert.ToInt32(fields[0]);
            stu.Name = fields[1];
            stu.Gpa = Convert.ToDouble(fields[2]);
            WriteLine("{0,-10}{1,-12}{2,8}", stu.StuNum, stu.Name, stu.Gpa.ToString("F2"));
            recordIn = reader.ReadLine();
        }

        reader.Close();
        inFile.Close();
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
