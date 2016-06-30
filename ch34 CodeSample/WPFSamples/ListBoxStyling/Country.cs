using System;
using System.Collections.Generic;
using System.Text;

namespace ListBoxStyling
{
   public class Country
   {
      public Country(string name)
         : this(name, null)
      {
      }

      public Country(string name, string imagePath)
      {
         this.Name = name;
         this.ImagePath = imagePath;
      }

      public string Name { get; set; }
      public string ImagePath { get; set; }

      public override string ToString()
      {
         return Name;
      }
   }

}
