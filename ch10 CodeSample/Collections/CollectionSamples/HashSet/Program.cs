using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   class Program
   {
      static void Main()
      {
         HashSet<string> companyTeams = new HashSet<string>() { "Ferrari", "McLaren", "Toyota", "BMW", "Renault", "Honda" };
         HashSet<string> traditionalTeams = new HashSet<string>() { "Ferrari", "McLaren" };
         HashSet<string> privateTeams = new HashSet<string>() { "Red Bull", "Toro Rosso", "Spyker", "Super Aguri" };

         if (privateTeams.Add("Williams"))
            Console.WriteLine("Williams added");
         if (!companyTeams.Add("McLaren"))
            Console.WriteLine("McLaren was already in this set");

         if (traditionalTeams.IsSubsetOf(companyTeams))
         {
            Console.WriteLine("traditionalTeams is a subset of companyTeams");
         }

         if (companyTeams.IsSupersetOf(traditionalTeams))
         {
            Console.WriteLine("companyTeams is a superset of traditionalTeams");
         }

         traditionalTeams.Add("Williams");
         if (privateTeams.Overlaps(traditionalTeams))
         {
            Console.WriteLine("at least one team is the same with the traditional and private teams");
         }

         HashSet<string> allTeams = new HashSet<string>(companyTeams);
         allTeams.UnionWith(privateTeams);
         allTeams.UnionWith(traditionalTeams);

         Console.WriteLine();
         Console.WriteLine("all teams");
         foreach (var team in allTeams)
         {
            Console.WriteLine(team);
         }


         allTeams.ExceptWith(privateTeams);
         Console.WriteLine();
         Console.WriteLine("no private team left");
         foreach (var team in allTeams)
         {
            Console.WriteLine(team);
         }


      }
   }
}
