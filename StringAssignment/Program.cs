using System;
using System.Text;

namespace StringAssignment
{
    internal class Program
    {
        static void Main()
        {
            string A = "My name is Sunpreet Kaur";
            string B = " and I reside in Toronto";
            string X = " Toronto is a happy place to live in.";


            String C = A + B +X ;
            Console.WriteLine(C);
            
            String D = "I like Canada";
            D = D.ToUpper();
            Console.WriteLine(D);

            StringBuilder sb= new StringBuilder();
            sb.Append("My name is Sunpreet. ");
            sb.Append(" I live in Toronto.");
            sb.Append(" Toronto is a happy place to live in.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
