using System;

namespace Day2.Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = { new Employee { ID = 1, salary = 5000 }, new Employee { ID = 2, salary = 9000 }, new Employee { ID = 3, salary = 2000 } };
           
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].salary}");
            }


            arr[0].Compare(arr[0], arr[1]);





         


        }




    }
}
