using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.WPF
{
   public class BookFactory
   {
      private List<Book> books = new List<Book>();

      public BookFactory()
      {
         books.Add(new Book("Professional C# 2008",
               "Wrox Press", "978-0470191378"));
      }

      public Book GetTheBook()
      {
         return books[0];
      }
   }

}
