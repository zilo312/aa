using System;
using System.Data;
using System.Data.SqlClient;
using Wrox.ProCSharp.SqlServer;


   class Program
   {
      static void Main()
      {
         string connectionString =
            @"server=(local);database=ProCSharp;trusted_connection=true";
         SqlConnection connection = new SqlConnection(connectionString);
         SqlCommand command = connection.CreateCommand();
         command.CommandText = "SELECT Id, Name, Location FROM Cities";
         connection.Open();

         SqlDataReader reader =
               command.ExecuteReader(CommandBehavior.CloseConnection);
         while (reader.Read())
         {
            string name = reader.GetString(1);
            SqlCoordinate coordinate = (SqlCoordinate)reader.GetValue(2);
            Console.WriteLine("{0,-10} {1}", name, coordinate);
         }
         reader.Close();

      }
   }
