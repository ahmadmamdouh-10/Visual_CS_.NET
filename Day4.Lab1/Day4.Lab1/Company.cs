using System;
using System.Collections.Generic;
using System.Text;

namespace Day4.Lab1
{
    class Company  //subcriber
    {
        public string Name { set; get; }
        public float Budget { set; get; }
        List<Employee> employees;

        public Company(string _Name, List<Employee> _Employee)
        {
            Name = _Name;
            employees = _Employee;
            Budget = 100000;
        }

        public void EmpSalaryIncreased(object sender, float amount)
        {
            Budget -= amount;
        }

        public static void Display(List<Employee> list, Predicate<Employee> filter)
        {
            foreach(Employee item in list)
            {
                if (filter(item))
                {
                    Console.WriteLine($"{item.Name} :: {item.Salary}");
                }
            }

        }

        }

    }
}
