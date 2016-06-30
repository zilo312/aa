using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   [Serializable]
   public class Person
   {
      public Person(string name)
      {
         this.name = name;
      }

      private string name;

      public override string ToString()
      {
         return name;
      }
	
   }
}
