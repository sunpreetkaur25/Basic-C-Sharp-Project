using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_Assignment
{
    public abstract class Person

    {
        public string FirstName;
        public string LastName;
       
        public void SayName()
        {

            Console.WriteLine("FirstName: {0}", FirstName);
            Console.WriteLine("LastName: {0}", LastName);
        }
    }
}
