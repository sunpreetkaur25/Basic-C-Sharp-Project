using System;

    internal class Program
    {
        static void Main()
        {
        Console.WriteLine("Pick a number");
        int number= Convert.ToInt32(Console.ReadLine());
        List<int> numbers = new List<int> () { 1,2,3,4,5,6,7,8,9,10 };

        foreach (int number in numbers)
        { 
            int  newnumber = numbers/number;
            Console.WriteLine(newnumber);
        }
        {
            x = 0;

            for (int i = 0; i < j; i++)
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
    