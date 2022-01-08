using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main()
        {
            List<string> intlist = new List<string>();
            intlist.Add("My");
            intlist.Add("name");
            intlist.Add("is");
            intlist.Add("Sunpreet");
            intlist.Add("Kaur");
            Console.WriteLine();
            Console.ReadLine();

            int[] numArray = new int[5];
            numArray[0] = 1;
            numArray[1] = 2;    
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            int[] numArray1 = new int[5];

            Console.WriteLine(numArray1);
            Console.ReadLine();


        }
    }
}
