using System;
using System.Collections.Generic;

namespace Wrox.ProCSharp.Collections
{
   [Serializable]
   public class Racer : IComparable<Racer>, IFormattable //, IEquatable<Racer>
   {
      public Racer() 
         : this (String.Empty, String.Empty, String.Empty) {}

      public Racer(string firstName, string lastName, string country)
         : this(firstName, lastName, country, 0) {}

      public Racer(string firstName, string lastName, string country, int wins)
      {
         this.FirstName = firstName;
         this.lastName = lastName;
         this.country = country;
         this.wins = wins;
      }

       public string FirstName
       {
           get;
           set;
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
         return FirstName + " " + lastName;
      }

      public override int GetHashCode()
      {
         return lastName.GetHashCode();
      }


      #region IComparable<Racer> Members

      public int CompareTo(Racer other)
      {
          int compare = this.lastName.CompareTo(other.lastName);
          if (compare == 0)
              return this.FirstName.CompareTo(other.FirstName);
         return compare;
      }

      #endregion

      #region IFormattable Members

      public string ToString(string format, IFormatProvider formatProvider)
      {
          if (format != null) format = format.ToUpper();
         switch (format)
         {
            case null:
            case "N":
               return ToString();
            case "F":
               return FirstName;
            case "L":
               return lastName;
            case "W":
               return String.Format("{0}, Wins: {1}", ToString(), wins);
            case "C":
               return String.Format("{0}, Country: {1}", ToString(), country);
            case "A":
               return String.Format("{0}, {1} Wins: {2}", ToString(), country, wins);
            default:
               throw new FormatException(String.Format(formatProvider, "Format {0} is not supported", format));
         }
      }

      public string ToString(string format)
      {
         return ToString(format, null);
      }

      #endregion

      //#region IEquatable<Racer> Members

      //public bool Equals(Racer other)
      //{
      //   return this.lastName.Equals(other.lastName);
      //}

      //#endregion

      // public override bool Equals(object obj)
      // {
      //     if (!(obj is Racer))
      //         return false;
      //     return this.Equals(obj as Racer);
      // }

      // public static bool operator ==(Racer r1, Racer r2)
      // {
      //     return r1.Equals(r2);
      // }

      // public static bool operator !=(Racer r1, Racer r2)
      // {
      //     return !(r1 == r2);
      // }

      // public static bool operator <(Racer r1, Racer r2)
      // {
      //     return (r1.CompareTo(r2) < 0);
      // }

      // public static bool operator >(Racer r1, Racer r2)
      // {
      //     return (r1.CompareTo(r2) > 0);
      // }
   }
}
