using System;

    internal class Program
    {
        static void Main()
        {
        string A= "Anonymous Income Comparison Program";
        Console.WriteLine(A);
        Console.WriteLine("Person 1");

        Console.WriteLine("Hours Rate?");
        int HoursRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int Hoursperweek = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Person 2");

        Console.WriteLine("Hours Rate?");
        int HoursRate2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int Hoursperweek2 = Convert.ToInt32(Console.ReadLine());

        int Salary1 = Hoursperweek * HoursRate;
        int AnnualS1 = Salary1 * 52;
        Console.WriteLine("Annual salary of Person 1:" + AnnualS1);
        int Salary2 = Hoursperweek2 * HoursRate2;
        int AnnualS2 = Salary2 * 52;
        Console.WriteLine("Annual salary of Person 2:"  + AnnualS2);

        
        Console.WriteLine("Person 1 makes more money than Person 2");
        bool B= Salary1> Salary2;
        Console.WriteLine(B);
        Console.ReadLine();

        
    }
}
