using System;
using System.Data;
using System.Data.SqlClient;

namespace ClientApp
{
   class Program
   {
      static void Main()
      {
         string connectionString =
             @"server=(local);database=AdventureWorks;trusted_connection=true";
         SqlConnection connection = new SqlConnection(connectionString);
         SqlCommand command = connection.CreateCommand();
         command.CommandText = "GetCustomerOrdersCLR";
         command.CommandType = CommandType.StoredProcedure;
         SqlParameter param = new SqlParameter("@customerId", 3);
         command.Parameters.Add(param);
         connection.Open();
         SqlDataReader reader =
               command.ExecuteReader(CommandBehavior.CloseConnection);
         while (reader.Read())
         {
            Console.WriteLine("{0} {1:d}", reader["SalesOrderID"],
               reader["OrderDate"]);
         }
         reader.Close();

      }
   }
}
