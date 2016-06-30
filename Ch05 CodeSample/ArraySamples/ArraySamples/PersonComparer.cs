using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Arrays
{
    public class PersonComparer : IComparer
    {
        public enum PersonCompareType
        {
            FirstName,
            LastName
        }

        private PersonCompareType compareType;

        public PersonComparer(PersonCompareType compareType)
        {
            this.compareType = compareType;
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            switch (compareType)
            {
                case PersonCompareType.FirstName:
                    return p1.FirstName.CompareTo(p2.FirstName);
                case PersonCompareType.LastName:
                    return p1.LastName.CompareTo(p2.LastName);
                default:
                    throw new ArgumentException("unexpected compare type");
            }
            
        }

        #endregion
    }
}
