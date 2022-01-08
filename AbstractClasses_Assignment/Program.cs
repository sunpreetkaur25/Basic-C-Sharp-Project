using System;

namespace Abstract_Classes
{
  // Abstract class
  abstract class Person

{
    public string FirstName;
    public string LastName;
    public Person()
    {
        Console.WriteLine();
    }
    public abstract void SayName()
    {

        Console.WriteLine("FirstName: {0}", FirstName);
        Console.WriteLine("LastName: {0}", LastName);
    }

    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Sayname = new Employee();
            Sayname.FirstName();
            Sayname.LastName();
        }
    }
}