using System;
using System.Collections.Generic;

namespace Wrox.ProCSharp.Transactions
{
    [Serializable]
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

        public CourseDate[] CourseDates
        {
            get { return courseDates.ToArray(); }
            set
            {
                courseDates = new List<CourseDate>(value);
            }
        }

        public void AddDate(CourseDate date)
        {
            courseDates.Add(date);
        }
    }
}
