using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    public class ImplicitImplementation : ImplicitBase, IGetsMessage2 
    {
           public new string GetMessage()
        {
            return nameof(IGetsMessage2);
        }
    }
}
