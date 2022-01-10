using System;


namespace AbstractClasses_Assignment
{

    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

        }
    }
}