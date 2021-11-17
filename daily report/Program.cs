using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you in?");
        string A = Console.ReadLine();
        Console.WriteLine("What page number?");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? Please answer “true” or “false");
        bool C = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
        string D = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string E = Console.ReadLine();
        Console.WriteLine("How many hours did you study today ?");
        int F = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("“Thank you for your answers. An Instructor will respond shortly.Have a great day!” This will be the end of the program.");
    }
}