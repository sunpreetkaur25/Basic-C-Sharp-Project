using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Age in the format dd-mm-yyyy");
                DateTime dt = Convert.ToDateTime(Console.ReadLine());

                int year = dt.Year;

                Console.WriteLine("The year in the date you entered: " + year);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please enter a positive or non-zero number");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    }
