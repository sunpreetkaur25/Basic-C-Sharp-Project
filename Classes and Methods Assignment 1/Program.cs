using System;
using System.Collections.Generic;

namespace classesAssignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            string a = String.Empty;
            do
            {
                Console.WriteLine("Please enter two numbers:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please choose the Operation you want to perfom");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Substraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Answer:" + add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Answer:" + substraction(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Answer:" + multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Answer:" + divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Please input again");
                        break;
                }
                a = Console.ReadLine();
            }
            while (a == "y");
        }
        //methods for integer operation
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int substraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //methods for floats operations
        public static float add_f(int num1, int num2)
        {
            return num1 + num2;
        }

        public static float sub_f(int num1, int num2)
        {
            return num1 - num2;
        }

        public static float mult_f(int num1, int num2)
        {
            return num1 / num2;
        }

        public static float div_f(int num1, int num2)
        {
            return num1 / num2;
        }

        //method to convert a string to a number
        public static void ConvertString()
        {
            string input = String.Empty;
            try
            {
                int result = Int32.Parse(input);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse' {input}'");
            }
            //Output unable to parse
            try
            {
                int num_val = Int32.Parse("-105");
                Console.WriteLine(num_val);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
