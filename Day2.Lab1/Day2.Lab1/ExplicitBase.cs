using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    public class ExplicitBase:IGetsMessage1
    {
          public virtual string GetMessage()
        {
            string s = "this the Message1 implements in Parent Class";
            return s;
        }
    }
}
