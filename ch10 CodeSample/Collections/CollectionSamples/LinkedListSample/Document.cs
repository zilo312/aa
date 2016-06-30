using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   public class Document
   {
       private string title;
       public string Title
       {
           get
           {
               return title;
           }
       }

       private string content;
       public string Content
       {
           get
           {
              return content;
           }
       }

      private byte priority;
       public byte Priority
       {
           get
           {
              return priority;
           }
       }

      public Document(string title, string content, byte priority)
      {
         this.title= title;
         this.content = content;
         this.priority = priority;
      }
   }

}
