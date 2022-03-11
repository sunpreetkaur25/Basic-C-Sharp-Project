using System;
using System.Collections.Generic;
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:" + some_ops(num1, num2));
        }

        public static int some_ops(int num1, int num2)
        {
            return num1 + num1;
        }
    }
}

