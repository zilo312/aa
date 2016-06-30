using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Transactions
{
    public class CourseDate
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
	
	
	
    }
}
