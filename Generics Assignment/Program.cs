using System;

namespace Generics_Assignment
{

     class GenericEmployeeList<T>
    {
        public void Add(T input) { }
    }
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
           
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

         
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

        
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }

        GenericList<int> list = new GenericList<int>();

        foreach (int i in list)
        {
            System.Console.Write();
        }
    }
