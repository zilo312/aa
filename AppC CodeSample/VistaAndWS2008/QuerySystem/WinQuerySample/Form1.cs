using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Interop.SearchAPI;

namespace WinQuerySample
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private string GetSql(string aqs)
      {
         CSearchManager searchManager = new CSearchManager();
         CSearchCatalogManager catalogManager = searchManager.GetCatalog("SystemIndex");
         CSearchQueryHelper queryHelper = catalogManager.GetQueryHelper();
         return queryHelper.GenerateSQLFromUserQuery(aqs);
      }

      private void buttonSearch_Click(object sender, EventArgs e)
      {
         try
         {
            listViewResult.Clear();

            string indexerConnectionString = "provider=Search.CollatorDSO.1;EXTENDED PROPERTIES='Application=Windows'";
            OleDbConnection connection = new OleDbConnection(indexerConnectionString);
            connection.Open();
            //    string sql = "SELECT System.ItemName, System.Title, System.Size FROM SYSTEMINDEX WHERE System.Size > 1024";
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = GetSql(textBoxQuery.Text);
            OleDbDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
               listViewResult.Columns.Add(row[0].ToString()); //, 200, HorizontalAlignment.Left);
            }
 
            while (reader.Read())
            {
               ListViewItem item = new ListViewItem(reader[0].ToString());
               for (int i = 1; i < reader.FieldCount; i++)
               {
                  if (reader[i] is string[])
                  {
                     
                     item.SubItems.Add(String.Join(", ", ((string[])reader[i])));
                  }
                  else
                  {
                     item.SubItems.Add(reader[i].ToString());
                  }
               }

               ////ListViewItem item = new ListViewItem(
               ////   new string[] {reader[0].ToString(), reader[1].ToString(), reader[2].ToString()});
               //ListViewItem item = new ListViewItem(reader[0].ToString());
               //item.SubItems.Add(reader[1].ToString());
               //item.SubItems.Add(reader[2].ToString());

               listViewResult.Items.Add(item);
//               listView1.Items.Add(item);
               
//               Console.WriteLine("{0} {1} {2}", reader[0], reader[1], reader[2]);
            }

            connection.Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}