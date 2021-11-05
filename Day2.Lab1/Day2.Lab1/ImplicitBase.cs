using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    public class ImplicitBase: IGetsMessage1
    {
        public string GetMessage()
        {
            return nameof(IGetsMessage1);
        }
    }
}
