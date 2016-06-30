using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Wrox.ProCSharp.Transactions
{
    public class CourseData
    {
        public void AddCourse(Course c)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CourseManagementConnectionString);
            SqlCommand courseCommand = connection.CreateCommand();
            courseCommand.CommandText = "INSERT INTO Courses (Number, Title) VALUES (@Number, @Title)";
            connection.Open();
            SqlTransaction tx = connection.BeginTransaction();

            try
            {
                courseCommand.Transaction = tx;

                courseCommand.Parameters.AddWithValue("@Number", c.Number);
                courseCommand.Parameters.AddWithValue("@Title", c.Title);
                int rowResult = courseCommand.ExecuteNonQuery();
                if (rowResult != 1)
                {
                    throw new Exception("ex");
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex.Message);
                tx.Rollback();
                Trace.WriteLine("Error: " + ex.Message);
            }
            connection.Close();
 
        }

        public void AddCourseDate(CourseDate courseDate)
        {
        }
    }
}
