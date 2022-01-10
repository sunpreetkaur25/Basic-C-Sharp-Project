using System;
using System.Collections.Generic;

namespace Generics_Assignment
{

    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> ();
            employee1.Things.Add("I am an Employee of Academy learning");
            employee1.Things.Add(" It is in Brampton");
            employee1.Things.Add("Canada");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(123);
            employee2.Things.Add(456);
            employee2.Things.Add(789);

            foreach (string s in employee1.Things)
            {
                Console.WriteLine(s);
            }
            foreach (int s in employee2.Things)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
