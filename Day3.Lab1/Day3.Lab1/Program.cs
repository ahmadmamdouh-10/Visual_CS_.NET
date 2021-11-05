using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Use Of Indexers
            //MyList L1 = new MyList();

            //L1[0] = "Ahmed";
            //L1[1] = "Ali";
            //L1[2] = "Mahmoud";
            //L1[3] = "Mohamed";
            //L1[4] = "Karim";
            //L1[5] = "Adel";

            //for(int i = 0; i < MyList.size; i++)
            //{
            //    Console.WriteLine(L1[i]);
            //} 
            #endregion

            MyList L1 = new MyList();

            L1.Add(new Employee { ID = 1, Name = "Ali" });
            L1.Add(new Employee { ID = 2, Name = "Hosam" });
            L1.Add(new Employee { ID = 3, Name = "Amgad" });

            foreach (Employee emp in L1)
            {
                Console.WriteLine($"Employe ID: {emp.ID} , Name: {emp.Name}");
            }



            for (int i = 0; i < MyList.index; i++)
            {
                Console.WriteLine($" Name: {L1[i].Name}");
            }


            Console.WriteLine("*************************************************************");


            //Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            //dic.Add(1, new Employee { ID = 1, Name = "Ali" });

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "A");
            dic.Add(2, "B");
            dic.Add(3, "C");
            dic.Add(4, "D");
            dic.Add(5, "E");

            foreach(KeyValuePair<int,string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }


            //List<Employee> myList = 






        }
    }
}
