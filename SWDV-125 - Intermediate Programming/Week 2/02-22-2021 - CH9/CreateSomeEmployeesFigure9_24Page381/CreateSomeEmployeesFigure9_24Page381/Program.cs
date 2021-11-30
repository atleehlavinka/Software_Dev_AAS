using static System.Console;
class CreateSomeEmployees
{
    static void Main()
    {
        Employee aWorker = new Employee();
        Employee anotherWorker = new Employee(234);
        Employee theBoss = new Employee('A');
        Employee newWorker = new Employee(888, 55000);
 
        WriteLine("{0, 4}{1, 14}", aWorker.IdNumber, aWorker.Salary.ToString("C"));

        WriteLine("{0, 4}{1, 14}", anotherWorker.IdNumber, anotherWorker.Salary.ToString("C"));

        WriteLine("{0, 4}{1, 14}", theBoss.IdNumber, theBoss.Salary.ToString("C"));

        WriteLine("{0, 4}{1, 14}", newWorker.IdNumber, newWorker.Salary.ToString("C"));

    }
}
public class Employee
{
    public int IdNumber { get; set; }
    public double Salary { get; set; }
    //page 381
    public Employee()
    {
        IdNumber = 999;
        Salary = 0;
    }
    public Employee(int empId)
    {
        IdNumber = empId;
        Salary = 0;
    }
    public Employee(int empId, double sal)           //works with provided constructor
    {
        IdNumber = empId;
        Salary = sal;
    }
    public Employee(char code)
    {
        IdNumber = 111;
        Salary = 100000;
    }
}