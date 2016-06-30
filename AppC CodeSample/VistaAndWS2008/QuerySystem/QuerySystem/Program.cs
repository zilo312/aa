using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace QuerySystem
{
   class Program
   {
      static void Main()
      {
         string indexerConnectionString = "provider=Search.CollatorDSO.1;EXTENDED PROPERTIES='Application=Windows'";
         OleDbConnection connection = new OleDbConnection(indexerConnectionString);
         connection.Open();
         string sql = "SELECT System.ItemName, System.Title, System.Size FROM SYSTEMINDEX WHERE System.Size > 1024";
         OleDbCommand command = connection.CreateCommand();
         command.CommandText = sql;
         OleDbDataReader reader = command.ExecuteReader();
         while (reader.Read())
         {
            Console.WriteLine("{0} {1} {2}", reader[0], reader[1], reader[2]);
         }

         connection.Close();
      }
   }
}
