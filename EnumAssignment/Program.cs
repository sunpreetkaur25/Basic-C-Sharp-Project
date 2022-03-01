using System;


namespace EnumAssignment
{
    internal class Program
    {
       
          enum weekdays
        {
            Sunday, 
            Monday,   
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday      
        }

        static void Main(string[] args)
        {
        try {
                 Console.ReadLine();
                Console.WriteLine("enter the current day of the week");

                weekdays myVar = weekdays.Monday;
                Console.WriteLine(myVar);
            }
        catch (Exception e)
{
  Console.WriteLine("Please enter an actual day of the week");
}
}
    }
}
