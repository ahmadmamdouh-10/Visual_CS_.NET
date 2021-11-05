using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lambda Expression & Anonymous Functions
            //Employee e1 = new Employee { Name = "Ahmed", Salary = 8000 };
            //Employee e2 = new Employee { Name = "Ali", Salary = 8000 };
            //Employee e3 = new Employee { Name = "Mona", Salary = 8000 };
            //Employee e4 = new Employee { Name = "Karim", Salary = 8000 };
            //Employee e5 = new Employee { Name = "Mahmoud", Salary = 8000 };
            //Employee e6 = new Employee { Name = "John", Salary = 2000 };
            //Employee e7 = new Employee { Name = "Omar", Salary = 2000 };
            //Employee e8 = new Employee { Name = "Cristiano", Salary = 2000 };
            //Employee e9 = new Employee { Name = "Ronald", Salary = 5000 };
            //Employee e10 = new Employee { Name = "Mohamed", Salary = 5000 };

            //List<Employee> employees = new List<Employee>();

            //employees.Add(e1);
            //employees.Add(e2);
            //employees.Add(e3);
            //employees.Add(e4);
            //employees.Add(e5);
            //employees.Add(e6);
            //employees.Add(e7);
            //employees.Add(e8);
            //employees.Add(e9);
            //employees.Add(e10);

            //Company c1 = new Company("Amazon", employees);

            //Console.WriteLine(" Budget Before Salary Increase\n");
            //Console.WriteLine(c1.Budget);

            //Console.WriteLine("=============================================\n");

            ////Making Event MultiCastingDelegate contains 3 function of Increased. 
            //e1.SalaryIncreased += c1.EmpSalaryIncreased;
            //e7.SalaryIncreased += c1.EmpSalaryIncreased;
            //e10.SalaryIncreased += c1.EmpSalaryIncreased;


            //e1.IncreaseSalary(2000);
            //e7.IncreaseSalary(2000);
            //e10.IncreaseSalary(2000);



            //Console.WriteLine(e1.Salary);  //10000
            //Console.WriteLine(e7.Salary);  // 4000
            //Console.WriteLine(e10.Salary); //7000

            //Console.WriteLine(" Budget After Salary Increase\n");




            //Console.WriteLine(c1.Budget);

            //Console.WriteLine("=============================================\n");

            //Console.WriteLine(" Filtering Employee whose Salaries > 5000 ");

            //Company.Display(employees, delegate (Employee employee)   //Anonymous Function 
            //{
            //    return employee.Salary > 5000;
            //});

            //Console.WriteLine("=============================================\n");

            //Console.WriteLine(" Filtering Employee whose Salaries < 5000 ");

            //Company.Display(employees, employee => employee.Salary < 5000);  //Lambda Expression



            //Console.WriteLine("=============================================\n");

            //Console.WriteLine(" Filtering Employee whose Salaries Equal 5000 ");


            //Company.Display(employees, employee => employee.Salary == 5000);  //Lambda Expression

            #endregion












        }
    }
}
