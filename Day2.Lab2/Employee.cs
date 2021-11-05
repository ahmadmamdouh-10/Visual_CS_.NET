using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab2
{
    class Employee: IComparable, IComparer
    {
        public int ID {get; set;}

        public int salary { get; set; }

        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;

            if (salary<e.salary)
            {
                return -1;

            }
            else if (salary > e.salary)
            {
                return 1;
            }
            else return 0;
        }


        public int Compare(object x, object y)
        {
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
            if (e1.salary > e2.salary)
            {
                Console.WriteLine($"Salary of Employee ID = {e1.ID} is MORE (>) than Salary of Employee ID  = {e2.ID} ");

                return 1;
            }
                
            if (e1.salary < e2.salary)
            {
                Console.WriteLine($"Salary of Employee ID = {e1.ID} is LOWER (<) than Salary of Employee ID  = {e2.ID} ");
                return -1;
            }

            else
            {
                Console.WriteLine($"Salary of Employee ID = {e1.ID} is EQUAL (=) than Salary of Employee ID  = {e2.ID} ");
                return 0;
            }

               


        }
    }
}
