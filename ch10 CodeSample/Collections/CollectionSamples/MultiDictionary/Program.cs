using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
 

   class Program
   {
      static void Main()
      {
         MultiValueDictionary<string, Racer> racers = new MultiValueDictionary<string, Racer>();
         racers.Add("Canada", new Racer("Jacqes", "Villeneuve", "Canada", 11));
         racers.Add("Australia", new Racer("Alan", "Jones", "Australia", 12));
         racers.Add("United Kingdom", new Racer("Jackie", "Stewart", "United Kingdom", 27));
         racers.Add("United Kingdom", new Racer("James", "Hunt", "United Kingdom", 10));
         racers.Add("Australia", new Racer("Jack", "Brabham", "Australia", 14));

         foreach (Racer r in racers["Australia"])
         {
            Console.WriteLine(r);
         }





         MultiValueDictionary<int, string> multimap = new MultiValueDictionary<int, string>();
         multimap.Add(1, "one");
         multimap.Add(1, "two");
         multimap.Add(2, "three");
         multimap.Add(3, "four");

         Console.WriteLine(multimap.Count);
         //multimap.Remove(1);
         //Console.WriteLine(multimap.Count);
         Console.WriteLine(multimap.Contains(new KeyValuePair<int, string>(4, "three")));

         foreach (string s in multimap.Values)
         {
            Console.WriteLine(s);  
         }

         foreach (KeyValuePair<int, string> var in multimap)
         {
            Console.WriteLine(var.Key);
         }
      }
   }
}
