using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    public class Person : IComparable, ICloneable
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }




        #region IComparable Members

        public int CompareTo(object obj)
        {
            Person other = obj as Person;
            return this.LastName.CompareTo(other.LastName);           
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new Person(FirstName, LastName);
        }

        #endregion
    }
}
