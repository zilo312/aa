using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using System.Diagnostics;

namespace Wrox.ProCSharp.Collections
{
   //struct Test
   //{
   //   public int a;
   //   public int b;
   //}

   public class RacerEqualityComparer : EqualityComparer<Racer>
   {
      public override bool Equals(Racer x, Racer y)
      {
         return x.LastName.Equals(y.LastName);
      }

      public override int GetHashCode(Racer obj)
      {
         return obj.GetHashCode();
      }
   }

   public class FindCountry
   {
      public FindCountry(string country)
      {
         this.country = country;
      }
      private string country;

      public bool FindCountryPredicate(Racer racer)
      {
         if (racer == null) throw new ArgumentNullException("racer");
         return racer.Country == country;
      }
   }

   class Program
   {
       static void ListDemo2()
       {
           Racer graham = new Racer("Graham", "Hill", "UK", 14);
           Racer emerson = new Racer("Emerson", "Fittipaldi", "Brazil", 14);
           Racer mario = new Racer("Mario", "Andretti", "USA", 12);

           List<Racer> racers = new List<Racer>(20) { graham, emerson, mario };
           Console.WriteLine(racers.Capacity);

       }

      static void ListDemo()
      {
         List<Racer> racers = new List<Racer>(20);

         Racer graham = new Racer("Graham", "Hill", "UK", 14);
         racers.Add(graham);
         Racer emerson = new Racer("Emerson", "Fittipaldi", "Brazil", 14);
         racers.Add(emerson);
         Racer mario = new Racer("Mario", "Andretti", "USA", 12); 
         racers.Add(mario);
         racers.Add(new Racer("Michael", "Schumacher", "Germany", 91));
         racers.Add(new Racer("Mika", "Hakkinen", "Finland", 20));
         
         racers.AddRange(new Racer[] {new Racer("Niki", "Lauda", "Austria", 25), new Racer("Alain", "Prost", "France", 51)});



          List<Racer> racers2 = new List<Racer>(20) { graham, emerson, mario };
         Console.WriteLine(racers.Capacity);

         racers.Insert(3, new Racer("Phil", "Hill", "USA", 3));

         for (int i = 0; i < racers.Count; i++)
         {
            Console.WriteLine(racers[i]);
         }

         foreach (Racer r in racers)
         {
            Console.WriteLine(r);
         }

         //racers.ForEach(
         //   delegate(Racer r)
         //   {
         //      Console.WriteLine(r);
         //   });

          racers.ForEach(r => Console.WriteLine("{0:A}", r));

         int index1 = racers.IndexOf(mario);

         int index2 = racers.FindIndex(new FindCountry("Finland").FindCountryPredicate);

         //int index3 = racers.FindIndex(
         //   delegate(Racer r)
         //   {
         //      return r.LastName == "Rindt";
         //   });
          int index3 = racers.FindIndex(r => r.LastName == "Rindt");

         //Racer racer = racers.Find(
         //   delegate(Racer r)
         //   {
         //      return r.FirstName == "Niki";
         //   });

          Racer racer = racers.Find(r => r.FirstName == "Niki");

         //List<Racer> bigWinners = racers.FindAll(
         //   delegate(Racer r)
         //   {
         //      return r.Wins > 20;
         //   });
          List<Racer> bigWinners = racers.FindAll(r => r.Wins > 20);

         foreach (Racer r in bigWinners)
	     {
             Console.WriteLine("{0:A}", r);		 
	     }


         

         Racer j = new Racer("Jochen", "Rindt", "Austria", 6);
         if (racers.Remove(j))
         {
            Console.WriteLine("removed");
         }

         //List<Racer> w = racers.FindAll(
         //   delegate(Racer r)
         //   {
         //      return r.Wins > 15;
         //   });
         List<Racer> w = racers.FindAll(r => r.Wins > 15);
         Console.WriteLine("Won more than 15 races");
         w.ForEach(Console.WriteLine);

         racers.Sort();

         Console.WriteLine("sorted...");
         racers.ForEach(Console.WriteLine);

         racers.Sort(new RacerComparer(RacerComparer.CompareType.Country));


         racers.ForEach(Console.WriteLine);

         //List<Person> persons = racers.ConvertAll<Person>(
         //   delegate(Racer r)
         //   {
         //      return new Person(r.FirstName + " " + r.LastName);
         //   });
          List<Person> persons = racers.ConvertAll<Person>(
              r => new Person(r.FirstName + " " + r.LastName));

          racers.Sort((r1, r2) => r2.Wins.CompareTo(r1.Wins));


         //racers.ForEach(Console.WriteLine);
         //racers.Sort();
         //racers.ForEach(Console.WriteLine);
         //racers.Sort(delegate(Racer r1, Racer r2)
         //{
         //   return r2.Wins.CompareTo(r1.Wins);
         //});
         //racers.ForEach(Console.WriteLine);
      }

      static void StackDemo()
      {
         Stack<char> alphabet = new Stack<char>();
         alphabet.Push('A');
         alphabet.Push('B');
         alphabet.Push('C');

         foreach (char item in alphabet)
         {
            Console.Write(item);
         }
         Console.WriteLine();

         while (alphabet.Count > 0)
         {
            Console.Write(alphabet.Pop());
         }
         Console.WriteLine();
      }

      static void Main()
      {
        // ListDemo();

       //  StackDemo();

        SortedListDemo();

      }

      private static void SortedListDemo()
      {
         SortedList<string, string> books = new SortedList<string, string>();
         books.Add(".NET 2.0 Wrox Box", "978-0-470-04840-5");
         books.Add("Professional C# 2005 with .NET 3.0", "978-0-470-12472-7");

         books["Beginning Visual C# 2005"] = "978-0-7645-4382-1";
         books["Professional C# 2008"] = "978-0-470-19137-6";

         foreach (KeyValuePair<string, string> book in books)
         {
            Console.WriteLine("{0}, {1}", book.Key, book.Value);
         }

         foreach (string isbn in books.Values)
         {
            Console.WriteLine(isbn);
            
         }

         foreach (string title in books.Keys)
         {
            Console.WriteLine(title);
         }
      }
   }
}
