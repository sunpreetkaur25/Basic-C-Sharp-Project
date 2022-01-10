using System;  
struct Number
{  
    public decimal Amount;    
}

public class Program
{


    public static void Main()
    {
        Number ms = new Number();
        ms.Amount = 234.678m;

        Console.WriteLine("The Amount is " + ms.Amount);
        Console.ReadLine();
    }
}   