using System;

namespace Interfaces
{
    interface IQuittable
    {
        void Quit();
    }


    class Employee : IQuittable
    {
        public void Quit()
        {

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.Quit();
        }
    }
}