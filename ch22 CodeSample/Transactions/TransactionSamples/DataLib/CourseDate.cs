using System;

namespace Wrox.ProCSharp.Transactions
{
    [Serializable]
    public class CourseDate
    {
        private int id;

        public int Id
        {
            get { return id; }
            internal set { id = value; }
        }


        public DateTime StartDate { get; set; }
        public int Length { get; set; }
    }
}
