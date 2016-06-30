#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

#endregion

namespace DataSourceGenericCollection
{
    public class Person
    {
        public Person( string name, Sex sex, DateTime dob )
        {
            _name = name;
            _sex = sex;
            _dateOfBirth = dob;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Sex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private string _name;
        private Sex _sex;
        private DateTime _dateOfBirth;
    }

    public enum Sex
    {
        Male,
        Female
    }
}
