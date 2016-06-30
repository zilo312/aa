using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    class Program
    {
        static void Main()
        {
            Hello obj = new Hello();
            foreach (string s in obj)
            {
                Console.WriteLine(s);
            }

        }
    }
}
