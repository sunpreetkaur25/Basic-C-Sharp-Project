﻿namespace OperatorOverload
{
    class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator == (Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)

                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID != employee2.ID)

                return false;
            else
                return true;
        }
    }
}