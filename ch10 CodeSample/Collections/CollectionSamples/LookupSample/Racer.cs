using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   [Serializable]
   public class Racer : IComparable<Racer>, IFormattable, IEquatable<Racer>
   {
      public Racer() 
         : this (String.Empty, String.Empty, String.Empty) {}

      public Racer(string firstName, string lastName, string country)
         : this(firstName, lastName, country, 0) {}

      public Racer(string firstName, string lastName, string country, int wins)
      {
         this.firstName = firstName;
         this.lastName = lastName;
         this.country = country;
         this.wins = wins;
      }


      private string firstName;

      public string FirstName
      {
         get { return firstName; }
         set { firstName = value; }
      }

      private string lastName;

      public string LastName
      {
         get { return lastName; }
         set { lastName = value; }
      }

      private string country;

      public string Country
      {
         get { return country; }
         set { country = value; }
      }
	

      private int wins;

      public int Wins
      {
         get { return wins; }
         set { wins = value; }
      }


      public override string ToString()
      {
         return firstName + " " + lastName;
      }

      public override int GetHashCode()
      {
         return lastName.GetHashCode();
      }


      #region IComparable<Racer> Members

      public int CompareTo(Racer other)
      {
         return this.lastName.CompareTo(other.lastName);
      }

      #endregion

      #region IFormattable Members

      public string ToString(string format, IFormatProvider formatProvider)
      {
         switch (format)
         {
            case null:
            case "N":
               return ToString();
            case "F":
               return firstName;
            case "L":
               return lastName;
            case "W":
               return ToString() + " Wins: " + wins;
            case "C":
               return ToString() + " Country: " + country;
            case "A":
               return ToString() + ", " + country + " Wins:" + wins;
            default:
               throw new FormatException(String.Format(formatProvider, "Format {0} is not supported", format));
         }
      }

      public string ToString(string format)
      {
         return ToString(format, null);
      }

      #endregion

      #region IEquatable<Racer> Members

      public bool Equals(Racer other)
      {
         return this.lastName.Equals(other.lastName);
      }

      #endregion
   }
}
