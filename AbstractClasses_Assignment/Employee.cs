using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_Assignment
{
    public class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("FirstName: {0}", FirstName);
            Console.WriteLine("LastName: {0}", LastName);
        }

    }
}


