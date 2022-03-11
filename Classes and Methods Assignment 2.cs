using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate class
            Program p = new Program();
            Console.WriteLine("Input two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result:" + nums(num1, num2));

        }

        public static int nums(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
