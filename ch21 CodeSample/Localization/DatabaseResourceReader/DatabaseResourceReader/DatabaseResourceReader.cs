#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Resources;


#endregion

namespace Wrox.ProCSharp.Localization
{
   public class DatabaseResourceReader : IResourceReader
   {
      private string connectionString;
      private string language;

      public DatabaseResourceReader(string connectionString, CultureInfo culture)
      {
         this.connectionString = connectionString;
         this.language = culture.Name;
      }
      public System.Collections.IDictionaryEnumerator GetEnumerator()
      {
         Dictionary<string, string> dict = new Dictionary<string, string>();

         SqlConnection connection = new SqlConnection(connectionString);
         SqlCommand command = connection.CreateCommand();
         if (String.IsNullOrEmpty(language))
            language = "Default";

         command.CommandText = "SELECT [key], [" + language + "] " +
            "FROM Messages";

         try
         {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
               if (reader.GetValue(1) != System.DBNull.Value)
                  dict.Add(reader.GetString(0).Trim(), reader.GetString(1));
            }
            Trace.WriteLine(String.Format("read resource for {0}", language));

            reader.Close();
         }
         catch (SqlException ex)	// ignore missing columns in the database
         {
            if (ex.Number != 207)
               throw;
//            Trace.WriteLine(ex.Message);
         }

         return dict.GetEnumerator();
      }

      public void Close()
      {
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return this.GetEnumerator();
      }

      void IDisposable.Dispose()
      {
      }
   }
}
