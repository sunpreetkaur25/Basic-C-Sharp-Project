using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        string filepath = @"out.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number start from:");
            do
            {
                counter++;
                Console.Write(counter + ",");
            } while (counter < 100);

            Console.ReadKey();

            FileStream streamfile = new FileStream(path: @"out.txt", FileMode.Open, FileAccess.Read);
            StreamWriter streamWriter = new StreamWriter(streamfile);
            streamWriter.WriteLine(counter);
            streamWriter.Close();
            StreamReader streamrrader = new StreamReader(streamfile);
            string content = streamrrader.ReadToEnd();
            streamrrader.Close();
            streamfile.Close();


        }
    }
}
