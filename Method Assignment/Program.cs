using System;


namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number to multiply by 50");
            int Multiply = 50 * A;
            Console.WriteLine(Multiply);

            Console.WriteLine("Enter a number to add to 25");
            int B = Convert.ToInt32(Console.ReadLine());
            int Add = B + 25;
            Console.WriteLine(Add);

            Console.WriteLine("Enter a number to divide by 12.5");
            int C = Convert.ToInt32(Console.ReadLine());
            double Divide = C / 12.5;
            Console.WriteLine(Divide);

            

        }
    }
}
