using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using System.Xml;

namespace XmlClient
{
   class Program
   {
      static void XmlReaderDemo()
      {
         string connectionString =
            @"server=(local);database=ProCSharp;trusted_connection=true";
         SqlConnection connection = new SqlConnection(connectionString);
         SqlCommand command = connection.CreateCommand();
         command.CommandText = "SELECT Id, Number, Info FROM Exams";
         connection.Open();
         SqlDataReader reader = command.ExecuteReader(
               CommandBehavior.CloseConnection);
         while (reader.Read())
         {
            SqlXml xml = reader.GetSqlXml(2);
            XmlReader xmlReader = xml.CreateReader();

            StringBuilder courses = new StringBuilder("Course(s): ", 40);
            while (xmlReader.Read())
            {
               if (xmlReader.Name == "Exam" && xmlReader.IsStartElement())
               {
                  Console.WriteLine("Exam: {0}", xmlReader.GetAttribute("Number"));
               }
               else if (xmlReader.Name == "Title" && xmlReader.IsStartElement())
               {
                  Console.WriteLine("Title: {0}", xmlReader.ReadString());
               }
               else if (xmlReader.Name == "Course" && xmlReader.IsStartElement())
               {
                  courses.AppendFormat("{0} ", xmlReader.ReadString());
               }
            }
            xmlReader.Close();
            Console.WriteLine(courses.ToString());
            Console.WriteLine();
         }
         reader.Close();
      }

      static void XmlDocumentDemo()
      {
         string connectionString =
               @"server=(local);database=ProCSharp;trusted_connection=true";
         SqlConnection connection = new SqlConnection(connectionString);
         SqlCommand command = connection.CreateCommand();
         command.CommandText = "SELECT Id, Number, Info FROM Exams";
         connection.Open();
         SqlDataReader reader = command.ExecuteReader(
               CommandBehavior.CloseConnection);
         while (reader.Read())
         {
            SqlXml xml = reader.GetSqlXml(2);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml.Value);

            XmlNode examNode = doc.SelectSingleNode("//Exam");
            Console.WriteLine("Exam: {0}", examNode.Attributes["Number"].Value);
            XmlNode titleNode = examNode.SelectSingleNode("./Title");
            Console.WriteLine("Title: {0}", titleNode.InnerText);
            Console.Write("Course(s): ");
            foreach (XmlNode courseNode in examNode.SelectNodes("./Course"))
            {
               Console.Write("{0} ", courseNode.InnerText);               
            }
            Console.WriteLine();

         }
         reader.Close();
      }

      static void Main()
      {
         // XmlReaderDemo();
         XmlDocumentDemo();
  

      }
   }
}
