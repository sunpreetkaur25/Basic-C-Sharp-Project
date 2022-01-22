using System;
using System.Threading.Tasks;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter w = new Streamwriter(m_exePath + "\\" + "log.txt"))
            {
                file.WriteLine(number);
            }
        }
    }
}