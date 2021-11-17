using System;


namespace while_and_dowhile
{
    internal class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
            Console.ReadLine();
        }
        }
    }
