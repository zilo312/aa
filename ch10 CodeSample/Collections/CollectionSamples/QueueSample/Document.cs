using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   [Serializable]
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

      public Document(string title, string content)
      {
         this.title = title;
         this.content = content;
      }
   }

}
