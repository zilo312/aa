using System;

namespace Wrox.ProCSharp.Transactions
{
   [Serializable]
   public class Student
   {
      public Student() { }

      public Student(string firstName, string lastName)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
      }

      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Company { get; set; }
      public int Id { get; set; }

      public override string ToString()
      {
         return String.Format("{0} {1}", FirstName, LastName);
      }

   }
}
