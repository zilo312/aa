using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Sorting
{
    class Program
    {
        static void DisplayNames(string title, IEnumerable<string> e)
        {
            Console.WriteLine(title);
            foreach (string s in e)
                Console.Write(s + " - ");
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Main()
        {
            string[] names = {"Alabama", "Texas", "Washington", 
                           "Virginia", "Wisconsin", "Wyoming", 
                           "Kentucky", "Missouri", "Utah", "Hawaii", 
                           "Kansas", "Lousiana", "Alaska", "Arizona"};

            Thread.CurrentThread.CurrentCulture =
               new CultureInfo("fi-FI");

            Array.Sort(names);
            DisplayNames("Sorted using the Finnish culture", names);

            // sort by using the invariant culture
            Array.Sort(names, System.Collections.Comparer.DefaultInvariant);
            DisplayNames("Sorted using the invariant culture", names);
        }
    }
}
