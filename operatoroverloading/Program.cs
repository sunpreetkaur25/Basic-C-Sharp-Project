using System;
using System.Collections.Generic;
namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "sunny";
            example.LastName = "kaur";
            example.ID = 123;

            Employee example2 = new Employee();
            example2.FirstName = "shanky";
            example2.LastName = "singh";
            example2.ID = 456;

            Console.WriteLine(example.ID == example2.ID);
            Console.ReadLine();
        }
    }
}