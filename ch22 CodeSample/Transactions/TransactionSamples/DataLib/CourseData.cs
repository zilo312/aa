using System;
using System.Data.SqlClient;


namespace Wrox.ProCSharp.Transactions
{
    public class CourseData
    {
        public void AddCourse(Course course)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CourseManagementConnectionString);
            SqlCommand courseCommand = connection.CreateCommand();
            courseCommand.CommandText = "INSERT INTO Courses (Number, Title) VALUES (@Number, @Title)";
            connection.Open();

            courseCommand.Parameters.AddWithValue("@Number", course.Number);
            courseCommand.Parameters.AddWithValue("@Title", course.Title);
            courseCommand.ExecuteNonQuery();

            connection.Close();
        }

        public void AddCourseDate(CourseDate courseDate)
        {
        }
    }
}
