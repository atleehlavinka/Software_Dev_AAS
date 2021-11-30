using System;
using static System.Console;
using static System.Array;
namespace LectureSchoolsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //page 395
            //page 401

            School[] schoolArray = new School[5]; 
            for (int x = 0; x < schoolArray.Length; ++x)
            {
                schoolArray[x] = new School();
                Write("Enter school name: ");
                //page 399
                schoolArray[x].Name = ReadLine();

                Write("Enter enrollment: ");
                schoolArray[x].Enrollment = Convert.ToInt32(ReadLine());
            }//end for

            Sort(schoolArray);
            WriteLine("\nSorted Schools");
            for (int x = 0; x < schoolArray.Length; ++x)
            {
                WriteLine("{0} School has {1} students", schoolArray[x].Name, schoolArray[x].Enrollment);
            }//end for

        }//end main
    }//end program
    class School : IComparable
    {
        public string Name { get; set; }
        public int Enrollment { get; set; }
        //page 398, Figure 9-40
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            School temp = (School)o;
            if (this.Enrollment > temp.Enrollment)
                returnVal = 1;
            else if (this.Enrollment < temp.Enrollment)
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;

        }//end IComparable
    }//class school
}
