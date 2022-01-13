using System;
using System.Collections.Generic;

namespace Exception_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number1 in numbers)
            {

                try
                {
                    int newnumber = number1 / number;
                    Console.WriteLine(newnumber);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You can't divide that.");
                }
                // This prevents the user from destroying reality as we know it
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You can't divide by zero.");
                }
                // This is here as a safety net
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally { } 
                
                }
                Console.ReadLine();
        }
    }
}
    