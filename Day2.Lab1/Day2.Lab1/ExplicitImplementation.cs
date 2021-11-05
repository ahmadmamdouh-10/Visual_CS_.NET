using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    public class ExplicitImplementation : IGetsMessage2, IGetsMessage1
    {
        public string GetMessage()
        {
            return nameof(IGetsMessage1);
        }

         string IGetsMessage2.GetMessage()
        {
            return nameof(IGetsMessage2);
        }

    }
}
