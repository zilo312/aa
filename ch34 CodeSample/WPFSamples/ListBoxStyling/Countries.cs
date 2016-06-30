using System;
using System.Collections.Generic;
using System.Text;

namespace ListBoxStyling
{
   public class Countries
   {
      public static IEnumerable<Country> GetCountries()
      {
         List<Country> countries = new List<Country>();
         countries.Add(new Country("Austria", "Images/Austria.bmp"));
         countries.Add(new Country("Germany", "Images/Germany.bmp"));
         countries.Add(new Country("Norway", "Images/Norway.bmp"));
         countries.Add(new Country("USA", "Images/USA.bmp"));

         return countries;
      }
   }

}
