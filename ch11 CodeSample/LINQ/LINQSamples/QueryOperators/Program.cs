using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Wrox.ProCSharp.LINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         // SimpleFiltering();
         //SimpleFilteringWithIndex();
         //TypeFiltering();
         // Filtering();
         // Ordering();
         // CompoundFrom();
         // Partitioning();
         // QuantifiersCount();
         // QuantifiersSum();
         // Grouping();
         // GroupingWithNestedObjects();
         // GroupingAndAggregation();
         // Join();

         //Range();

         // Expressions();

         // Conversion();

         // Intersect();
         NonGenericCollection();

      }

      private static void NonGenericCollection()
      {
         System.Collections.ArrayList list = new System.Collections.ArrayList(Formula1.GetChampions() as System.Collections.ICollection);
         

         var query = from r in list.Cast<Racer>()
                     where r.Country == "USA"
                     orderby r.Wins descending
                     select r;

         foreach (var racer in query)
         {
            Console.WriteLine("{0:A}", racer);
         }

      }

      private static void Conversion()
      {
         //// query executed immediately
         //List<Racer> racers = (from r in Formula1.GetChampions()
         //                      where r.Starts > 150
         //                      orderby r.Starts descending
         //                      select r).ToList();

         //foreach (var racer in racers)
         //{
         //   Console.WriteLine("{0} {0:S}", racer);
         //}

         ILookup<string, Racer> racers = (from r in Formula1.GetChampions()
                                          from c in r.Cars
                                          select new
                                          {
                                             Car = c,
                                             Racer = r
                                          }).ToLookup(cr => cr.Car, cr => cr.Racer);

         if (racers.Contains("Williams"))
         {
            foreach (var williamsRacer in racers["Williams"])
            {
               Console.WriteLine(williamsRacer);
            }
         }


      }

      private static void DisplayTree(int indent, string message, Expression expression)
      {
         string output = String.Format("{0} {1}! NodeType: {2}; Expr: {3} ", "".PadLeft(indent, '>'), message, expression.NodeType, expression);

         indent++;
         switch (expression.NodeType)
         {
            case ExpressionType.Lambda:
               Console.WriteLine(output);
               LambdaExpression lambdaExpr = (LambdaExpression)expression;
               foreach (var parameter in lambdaExpr.Parameters)
               {
                  DisplayTree(indent, "Parameter", parameter);
               }
               DisplayTree(indent, "Body", lambdaExpr.Body);
               break;
            case ExpressionType.Constant:
               ConstantExpression constExpr = (ConstantExpression)expression;
               Console.WriteLine("{0} Const Value: {1}", output, constExpr.Value);
               break;
            case ExpressionType.Parameter:
               ParameterExpression paramExpr = (ParameterExpression)expression;
               Console.WriteLine("{0} Param Type: {1}", output, paramExpr.Type.Name);
               break;
            case ExpressionType.Equal:
            case ExpressionType.AndAlso:
            case ExpressionType.GreaterThan:
               BinaryExpression binExpr = (BinaryExpression)expression;
               if (binExpr.Method != null)
                  Console.WriteLine("{0} Method: {1}", output, binExpr.Method.Name);
               else
                  Console.WriteLine(output);
               DisplayTree(indent, "Left", binExpr.Left);
               DisplayTree(indent, "Right", binExpr.Right);
               break;
            case ExpressionType.MemberAccess:
               MemberExpression memberExpr = (MemberExpression)expression;
               Console.WriteLine("{0} Member Name: {1}, Type: {2}", output, memberExpr.Member.Name, memberExpr.Type.Name);
               DisplayTree(indent, "Member Expr", memberExpr.Expression);
               break;
            default:
               Console.WriteLine();
               Console.WriteLine("....{0} {1}", expression.NodeType, expression.Type.Name);
               break;
         }
      }

      private static void Expressions()
      {
         Expression<Func<Racer, bool>> expression = r => r.Country == "Brazil" && r.Wins > 6;

         DisplayTree(0, "Lambda", expression);


      }


      private static void QuantifiersSum()
      {
         var countries = (from c in
                             from r in Formula1.GetChampions()
                             group r by r.Country into c
                             select new
                             {
                                Country = c.Key,
                                Wins = (from r1 in c
                                        select r1.Wins).Sum()
                             }
                          orderby c.Wins descending, c.Country
                          select c).Take(5);

         foreach (var country in countries)
         {
            Console.WriteLine("{0} {1}", country.Country, country.Wins);
         }

      }

      private static void Range()
      {
         var values = Enumerable.Range(1, 20).Select(n => n * 3);
         foreach (var item in values)
         {
            Console.Write("{0} ", item);
         }
         Console.WriteLine();
      }

      private static void Ordering()
      {
         //var racers = (from r in Formula1.GetChampions()
         //              orderby r.Country, r.LastName, r.FirstName
         //              select r).Take(10);

         var racers = Formula1.GetChampions().
            OrderBy(r => r.Country).
            ThenBy(r => r.LastName).
            ThenBy(r => r.FirstName).
            Take(10);

         foreach (var racer in racers)
         {
            Console.WriteLine("{0:C}: {0:L}, {0:F}", racer);
         }


      }

      private static void GroupingAndAggregation()
      {
         var countries = from c in
                            from r in Formula1.GetChampions()
                            group r by r.Country into g
                            select new
                            {
                               Country = g.Key,
                               Wins = (from x in g
                                       select x.Wins).Sum()
                            }
                         orderby c.Wins descending
                         select c;

         foreach (var item in countries)
         {
            Console.WriteLine(item);

         }
      }

      private static void GroupingWithNestedObjects()
      {
         var countries = from r in Formula1.GetChampions()
                         group r by r.Country into g
                         orderby g.Count() descending, g.Key
                         where g.Count() >= 2
                         select new
                         {
                            Country = g.Key,
                            Count = g.Count(),
                            Racers = from r1 in g
                                     orderby r1.LastName
                                     select r1.FirstName + " " + r1.LastName
                         };


         foreach (var item in countries)
         {
            Console.WriteLine("{0, -10} {1}", item.Country, item.Count);
            foreach (var name in item.Racers)
            {
               Console.Write("{0}; ", name);
            }
            Console.WriteLine();
         }
      }

      private static void SimpleFilteringWithIndex()
      {
         var racers = Formula1.GetChampions().Where((r, index) => r.LastName.StartsWith("A") && index % 2 != 0);
         foreach (var r in racers)
         {
            Console.WriteLine("{0:A}", r);
         }

      }

      private static void TypeFiltering()
      {
         object[] data = { "one", 2, 3, "four", "five", 6 };
         var query = data.OfType<string>();

         foreach (var s in query)
         {
            Console.WriteLine(s);
         }
      }

      private static void Join()
      {
         //var racers = from r in Formula1.GetChampions()
         //             from y in r.Years
         //             where y > 2003
         //             select new { Year = y, Name = r.FirstName + " " + r.LastName };
         //var teams = from t in Formula1.GetContructorChampions()
         //            from y in t.Years
         //            where y > 2003
         //            select new { Year = y, Name = t.Name };

         //var racersAndTeams = from r in racers
         //                     join t in teams on r.Year equals t.Year
         //                     select new { Year = r.Year, Racer = r.Name, Team = t.Name };


         int year = 2003;
         var racersAndTeams = from r in
                                 from r1 in Formula1.GetChampions()
                                 from yr in r1.Years
                                 where yr > year
                                 select new { Year = yr, Name = r1.FirstName + " " + r1.LastName }
                              join t in
                                 from t1 in Formula1.GetContructorChampions()
                                 from yt in t1.Years
                                 where yt > year
                                 select new { Year = yt, Name = t1.Name }
                              on r.Year equals t.Year
                              select new { Year = r.Year, Racer = r.Name, Team = t.Name };


         Console.WriteLine("Year  Champion             Constructor Title");
         foreach (var item in racersAndTeams)
         {
            Console.WriteLine("{0}: {1,-20} {2}", item.Year, item.Racer, item.Team);
         }
      }

      // public delegate IEnumerable<Racer> DriversByCar(string s);

      private static void Intersect()
      {
         Func<string, IEnumerable<Racer>> racersByCar =
            car => from r in Formula1.GetChampions()
                   from c in r.Cars
                   where c == car
                   orderby r.LastName
                   select r;

         Console.WriteLine("champion with Ferrari and McLaren");

         foreach (var racer in racersByCar("Ferrari").Intersect(racersByCar("McLaren")))
         {
            Console.WriteLine(racer);
         }
      }

      private static void CompoundFrom()
      {
         var ferrariDrivers = from r in Formula1.GetChampions()
                              from c in r.Cars
                              where c == "Ferrari"
                              orderby r.LastName
                              select r.FirstName + " " + r.LastName;


         var fd = Formula1.GetChampions().
             SelectMany(
               r => r.Cars,
               (r, c) => new { Racer = r, Car = c }).
               Where(r => r.Car == "Ferrari").
               OrderBy(r => r.Racer.LastName).
               Select(r => r.Racer.FirstName + " " + r.Racer.LastName);





         foreach (var racer in fd)
         {
            Console.WriteLine(racer);
         }


      }

      private static void Grouping()
      {
         var countries = from r in Formula1.GetChampions()
                         group r by r.Country into g
                         orderby g.Count() descending, g.Key
                         where g.Count() >= 2
                         select new { Country = g.Key, Count = g.Count() };

         //var query = Formula1.GetChampions().
         //    GroupBy(r => r.Country).
         //    OrderByDescending(g => g.Count()).
         //    ThenBy(g => g.Key).
         //    Where(g => g.Count() >= 2).Select(g => new { Country = g.Key, Count = g.Count() });

         foreach (var item in countries)
         {
            Console.WriteLine("{0,-10} {1}", item.Country, item.Count);
         }





      }

      private static void QuantifiersCount()
      {
         var racers = from r in Formula1.GetChampions()
                      where r.Years.Count() >= 3
                      orderby r.Years.Count() descending
                      select new
                      {
                         Name = r.FirstName + " " + r.LastName,
                         TimesChampion = r.Years.Count()
                      };

         foreach (var r in racers)
         {
            Console.WriteLine("{0} {1}", r.Name, r.TimesChampion);
         }


      }

      private static void Partitioning()
      {
         int pageSize = 5;

         int numberPages = (int)Math.Ceiling(Formula1.GetChampions().Count() / (double)pageSize);

         for (int page = 0; page < numberPages; page++)
         {
            Console.WriteLine("Page {0}", page);
            var racers = (from r in Formula1.GetChampions()
                          orderby r.LastName
                          select r.FirstName + " " + r.LastName).Skip(page * pageSize).Take(pageSize);           

            foreach (var name in racers)
            {
               Console.WriteLine(name);

            }
            Console.WriteLine();
         }

      }



      private static void SimpleFiltering()
      {
         var racers = from r in Formula1.GetChampions()
                      where r.Wins > 15 && (r.Country == "Brazil" || r.Country == "Austria")
                      select r;

         var racers2 = Formula1.GetChampions().
             Where(r => r.Wins > 15 && (r.Country == "Brazil" || r.Country == "Austria")).
             Select(r => r);

         foreach (var r in racers2)
         {
            Console.WriteLine("{0:A}", r);

         }
      }
   }
}
