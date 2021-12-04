using System;
using System.Collections.Generic;

namespace Assignment6_strings
{
    internal class Program
    {
        static void Main()
        {

            int j = 0;
            int x = 0;
            List<string> names = new List<string>() { "Mike", "Don", "Mark", "Paul", "Rita", "Mike", "Don" };
            foreach (string name in names)
            { x = 0;
                       
                for (int i = 0; i < j;i++) 
                {
                  
                    if (name == names[i]) 
                    {
                        x = 1;
                        Console.WriteLine(names[i] + " has already appeared in the list");
                    }
                }
                if (x == 0) 
                { Console.WriteLine(name + " has not already appeared in the list"); }

                j++;
            }
                    {
                Console.WriteLine(names);
            }
            Console.ReadLine();


        }
    }
}
