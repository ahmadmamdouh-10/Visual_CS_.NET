using System;
using System.Collections.Generic;
using System.Text;

namespace Day4.Lab1
{
    class Employee   //publisher
    {
        public string Name { set; get; }
        public float Salary { set; get; }
        public event Action<object, float> SalaryIncreased;


        public void IncreaseSalary(float amount)
        {
            Salary = Salary + amount;
            if(SalaryIncreased != null)
            {
                SalaryIncreased(this, amount);
            }
        }

      

    }
}
