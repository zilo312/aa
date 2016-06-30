using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.WPF
{
   public class Book
   {
      public Book(string title, string publisher, string isbn,
            params string[] authors)
      {
         this.Title = title;
         this.Publisher = publisher;
         this.Isbn = isbn;
         foreach (string author in authors)
         {
            this.authors.Add(author);
         }
      }

      public Book()
         : this("unknown", "unknown", "unknown")
      {
      }

      public string Title { get; set; }
      public string Publisher { get; set; }
      public string Isbn { get; set; }

      public override string ToString()
      {
         return Title;
      }

      private readonly List<string> authors = new List<string>();
      public string[] Authors
      {
         get { return authors.ToArray(); }
      }
   }

}
