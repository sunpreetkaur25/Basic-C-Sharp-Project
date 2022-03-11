using System;
using System.Collections.Generic;

namespace MethodAssignment
{
    public static class Bot
    {
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int div(int num1, int num2)
        {
            return num1 / num2;
        }

        internal static int div(string v)
        {
            throw new NotImplementedException();
        }

        internal static int sub(string v)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any two numbers to perform operation");


            Console.WriteLine("Please choose an operation");
            Console.WriteLine("1:Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Division");

            string selection = Console.ReadLine();
            int a, s, d = 0;
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter any two numbers to perform operation");

                    a = Bot.div(Console.ReadLine());
                    Console.WriteLine("Answer:", a);
                    break;
                case "2":
                    Console.WriteLine("Enter any two numbers to perform operation");
                    s = Bot.sub(Console.ReadLine());
                    Console.WriteLine("Answer:", s);
                    break;
                case "3":
                    Console.WriteLine("Enter any two numbers to perform operation");
                    a = Bot.div(Console.ReadLine());
                    Console.WriteLine("Answer:", a);
                    break;
                default:
                    Console.WriteLine("eRROR");
                    break;

            }
        }
    }
}
