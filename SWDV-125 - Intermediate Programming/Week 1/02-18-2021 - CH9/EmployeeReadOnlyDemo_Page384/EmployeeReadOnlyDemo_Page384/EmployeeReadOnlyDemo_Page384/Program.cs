using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EmployeeReadOnlyDemo_Page384
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myAssistant = new Employee(1234);
            Employee myDriver = new Employee(2345);
            myAssistant.IdNumber = 3456;
            WriteLine("{0}", myAssistant.IdNumber);
            WriteLine("{0}", myDriver.IdNumber);
        }
    }
    public class Employee
    {
        private readonly int idNumber;
        public Employee(int id)
        {
            idNumber = id;
        }

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            /*set
            {
                idNumber = value;
            }*/
        }
    }//end Employee

}
