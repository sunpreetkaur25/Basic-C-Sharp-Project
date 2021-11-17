using System;

namespace PriceQuote
    {
        internal class Program
        {
            static void Main()
            {
                string A = "Welcome to Package Express. Please follow the instructions below.";
                Console.WriteLine(A);

                Console.WriteLine("What is the package weight?");
                int weight = Convert.ToInt32(Console.ReadLine());
                if (weight> 50)
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                else
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

            int dimension = width + height + length;
            if (dimension > 50)
                Console.WriteLine("Package too big to be shipped via Package Express.");
         
            int B = width * height * length;
            int C = B * weight;
            int D = C/100;

            Console.WriteLine("Your estimated total for shipping this package is:" + C + "$");
            Console.ReadLine();
            }
        }
    }