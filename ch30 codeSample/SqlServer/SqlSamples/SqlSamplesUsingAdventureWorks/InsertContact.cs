using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;


public partial class Triggers
{

   // [Microsoft.SqlServer.Server.SqlTrigger (Name="InsertContact", Target="Person.Contact", Event="FOR UPDATE")]
   public static void InsertContact()
   {
      SqlTriggerContext triggerContext = SqlContext.TriggerContext;

      if (triggerContext.TriggerAction == TriggerAction.Insert)
      {
         SqlConnection connection = new SqlConnection(
               "Context Connection=true");
         SqlCommand command = new SqlCommand();
         command.Connection = connection;
         command.CommandText = "SELECT EmailAddress FROM INSERTED";
         connection.Open();
         string email = (string)command.ExecuteScalar();
         connection.Close();

         if (!Regex.IsMatch(email,
               @"([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"))
         {
            throw new FormatException("Invalid email");
         }
      }

   }
}
