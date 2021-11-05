using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExplicitImplementation ex = new ExplicitImplementation();

            //Console.WriteLine($"{ ((IGetsMessage1)ex).GetMessage()}");

            //Console.WriteLine($"{ ((IGetsMessage2)ex).GetMessage()}");
            
            Console.WriteLine(ex.GetMessage());   // msg 1 "Implicit Interface"

            Console.WriteLine(((IGetsMessage2)ex).GetMessage());   //msg 2 "Explicit Interface"
            











        }
    }
}
