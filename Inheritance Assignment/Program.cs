using System;


namespace Inheritance_Assignment
    {
        public class Person
        {
            public string FirstName;
            public string LastName;
            public Person()
            {
                Console.WriteLine();
            }
            public void SayName()
            {
              
                Console.WriteLine("FirstName: {0}", FirstName);
                Console.WriteLine("LastName: {0}", LastName);
            }
        }
        public class Employee: Person
        {
            public int Id;
            public Employee()
            {
                Console.WriteLine();
            }
            
        }
    class Program
    {
        static void Main(string[] args)
            {
            Employee d = new Employee();
                d.Id = 1;
                d.FirstName = ("Sample");
                d.LastName=("Student");
                d.SayName();
                Console.WriteLine("\nPress Any Key to Exit..");
                Console.ReadLine();
            }
        }
}
   
