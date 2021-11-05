using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterface
{
    class Human:I1, I2
    {
         void I1.MethodInterface()
        {
            Console.WriteLine("Method Interface I1 is running");
        }

        void I2.MethodInterface()
        {
            Console.WriteLine("Method Interface I2 is running");
        }
    }
}
