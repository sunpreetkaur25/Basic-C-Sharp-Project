using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter number to be processed");
            int N = Convert.ToInt32(Console.ReadLine());
            int out_a = OutParams(N);
            Console.WriteLine("Result: {0}", out_a);
            Console.ReadLine();
        }

        public static void divide(int n)
        {
            int ans = n / 2;
        }

        static public int OutParams(int n)
        {
            int i, val = 1;
            if (n == 1)
                return n;
            else
            {
                for (i = n; i > 0; i--)
                {
                    val = val / i;
                }
                return val;
            }
        }
    }
}
