using System;

namespace ExplicitInterface
{
    interface I1
    {
        void MethodInterface();
    }
    interface I2
    {
        void MethodInterface();
    }
    class Program 
    {
       
        static void Main(string[] args)
        {
            Human h = new Human();

            ((I1)h).MethodInterface();


            ((I2)h).MethodInterface();

            

        }
    }
}
