using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Transactions
{
    public class Course
    {
        private int id;

        public int Id
        {
            get { return id; }
            internal set { id = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private List<CourseDate> courseDates = new List<CourseDate>();

        public List<CourseDate> CourseDates
        {
            get { return courseDates = new List<CourseDate>(); }
        }
	
	
	
    }
}
