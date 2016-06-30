using System;
using System.Data.SqlClient;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main()
        {
            SqlConnection connection = new SqlConnection("server=(local);database=CourseManagement;trusted_connection=true");
            SqlCommand courseCommand = connection.CreateCommand();
            courseCommand.CommandText = "INSERT INTO Courses (Number, Title) VALUES (@Number, @Title)";
            connection.Open();
            SqlTransaction tx = connection.BeginTransaction();

            try
            {
                courseCommand.Transaction = tx;

                courseCommand.Parameters.AddWithValue("@Number", "2124");
                courseCommand.Parameters.AddWithValue("@Title", "C# Programming");
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
            }
            connection.Close();
 
        }
    }
}
