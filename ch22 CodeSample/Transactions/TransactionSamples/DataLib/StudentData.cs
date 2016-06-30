using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Wrox.ProCSharp.Transactions
{
   public class StudentData
   {

      public StudentData()
      {
      }


      #region GetStudents
      public Student[] GetStudents()
      {

         SqlConnection connection = new SqlConnection(Properties.Settings.Default.CourseManagementConnectionString);
         SqlCommand command = connection.CreateCommand();

         command.CommandText = "select Id, Firstname, Lastname, Company FROM Students";
         connection.Open();

         List<Student> students = new List<Student>();
         try
         {
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
               Student s = new Student();
               s.Id = reader.GetInt32(0);
               s.FirstName = reader.GetString(1);
               s.LastName = reader.GetString(2);
               s.Company = reader.GetString(3);

               students.Add(s);
            }
            reader.Close();
         }
         catch (Exception)
         {
            throw;
         }

         return students.ToArray();
      }
      #endregion

      #region AddStudent
      public void AddStudent(Student student)
      {
         AddStudent(student, null);

         #region {}
         // SqlConnection connection = new SqlConnection(
         //     Properties.Settings.Default.CourseManagementConnectionString);

         //SqlCommand command = connection.CreateCommand();

         // command.CommandText = "INSERT INTO Students (Firstname, Lastname, Company) VALUES (@Firstname, @Lastname, @Company)";
         // command.Parameters.AddWithValue("@Firstname", s.Firstname);
         // command.Parameters.AddWithValue("@Lastname", s.Lastname);
         // command.Parameters.AddWithValue("@Company", s.Company);

         // connection.Open();

         // try
         // {
         //     command.ExecuteNonQuery();
         // }
         // finally
         // {
         //     connection.Close();
         // }
         #endregion
      }
      #endregion

      #region AddStudent with a transaction
      public void AddStudent(Student student, Transaction tx)
      {
         SqlConnection connection = new SqlConnection(
             Properties.Settings.Default.CourseManagementConnectionString);
         connection.Open();
         try
         {
            if (tx != null)
               connection.EnlistTransaction(tx);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO Students (Firstname, Lastname, Company) VALUES (@Firstname, @Lastname, @Company)";
            command.Parameters.AddWithValue("@Firstname", student.FirstName);
            command.Parameters.AddWithValue("@Lastname", student.LastName);
            command.Parameters.AddWithValue("@Company", student.Company);

            command.ExecuteNonQuery();
         }
         finally
         {
            connection.Close();
         }

      }
      #endregion
   }
}
