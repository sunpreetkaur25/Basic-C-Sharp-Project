using System;


namespace PriceQuote
{
    internal class Program
    {
        static void Main()
        {
            string A = "Anonymous Income Comparison Program";
            Console.WriteLine(A);
            Console.WriteLine("Person 1");

            Console.WriteLine("What is your Age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = (Age > 15 && dui == false && speedingTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
