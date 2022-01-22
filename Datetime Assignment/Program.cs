using System;
using System.Threading.Tasks;
namespace DateTime
{
    class DateTime
    {
        private static DateTime now;
        public static void Main()

        {
            DateTime now = DateTime.now;
            Console.WriteLine(now);
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int X = Convert.ToInt32(Console.ReadLine());

        }
    }
}