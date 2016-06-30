#region Using directives

using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#endregion

namespace UserSearch
{
   partial class UserSearchForm : Form
   {
      private string username;
      private string password;
      private string hostname;
      private string schemaNamingContext;
      private string defaultNamingContext;

      public UserSearchForm()
      {
         InitializeComponent();
      }


      protected void SetLogonInformation()
      {
         username = (textBoxUsername.Text == "" ? null : textBoxUsername.Text);
         password = (textBoxPassword.Text == "" ? null : textBoxPassword.Text);
         hostname = textBoxHostname.Text;
         if (hostname != "") hostname += "/";
      }

      protected void SetNamingContext()
      {
         using (DirectoryEntry de = new DirectoryEntry())
         {
            string path = String.Format("LDAP://{0}rootDSE", hostname);
            de.Username = username;
            de.Password = password;
            de.Path = path;

            schemaNamingContext = de.Properties["schemaNamingContext"][0].ToString();
            defaultNamingContext = de.Properties["defaultNamingContext"][0].ToString();
         }
      }

      protected void SetUserProperties(string schemaNamingContext)
      {
         var properties =
            from p in
               GetSchemaProperties(schemaNamingContext, "User").Concat(
               GetSchemaProperties(schemaNamingContext, "Organizational-Person")).Concat(
               GetSchemaProperties(schemaNamingContext, "Person")).Concat(
               GetSchemaProperties(schemaNamingContext, "Top"))
            orderby p
            select p;

         listBoxProperties.Items.Clear();
         foreach (string s in properties)
         {
            listBoxProperties.Items.Add(s);
         }
      }

      protected IEnumerable<string> GetSchemaProperties(string schemaNamingContext, string objectType)
      {
         IEnumerable<string> data;
         using (DirectoryEntry de = new DirectoryEntry())
         {
            de.Username = username;
            de.Password = password;

            de.Path = String.Format("LDAP://{0}CN={1},{2}", hostname, objectType, schemaNamingContext);

            PropertyValueCollection values = de.Properties["systemMayContain"];
            data = from s in values.Cast<string>()
                   orderby s
                   select s;
         }
         return data;
      }

      private void OnLoadProperties(object sender, EventArgs e)
      {
         try
         {
            SetLogonInformation();
            SetNamingContext();

            SetUserProperties(schemaNamingContext);
         }
         catch (Exception ex)
         {
            MessageBox.Show(String.Format("Check your input: {0}", ex.Message));
         }
      }

      private void OnSearch(object sender, EventArgs e)
      {
         try
         {
            FillResult();
         }
         catch (Exception ex)
         {
            MessageBox.Show(String.Format("Check your input: {0}", ex.Message));
         }
      }


      protected void FillResult()
      {
         using (DirectoryEntry root = new DirectoryEntry())
         {
            root.Username = username;
            root.Password = password;
            root.Path = String.Format("LDAP://{0}{1}", hostname, defaultNamingContext);

            using (DirectorySearcher searcher = new DirectorySearcher())
            {
               searcher.SearchRoot = root;
               searcher.SearchScope = SearchScope.Subtree;
               searcher.Filter = textBoxFilter.Text;
               searcher.PropertiesToLoad.AddRange(
                  listBoxProperties.SelectedItems.Cast<string>().ToArray());

               SearchResultCollection results = searcher.FindAll();
               //var properties = from r in results.Cast<SearchResult>()
               //                 from propName in r.Properties.PropertyNames.Cast<string>()
               //                 select new
               //                 {
               //                    Name = propName,
               //                    Values = r.Properties[propName]
               //                 };

               //var values = from p in properties
               //             from v in p.Values.Cast<object>()
               //             select String.Format("{0}: {1}\r\n", p.Name, v.ToString());


               //StringBuilder summary = new StringBuilder(8192);
               //foreach (var item in values)
               //{
               //   summary.Append(item);
               //}



               StringBuilder summary = new StringBuilder();
               foreach (SearchResult result in results)
               {
                  foreach (string propName in result.Properties.PropertyNames)
                  {
                     foreach (object o in result.Properties[propName])
                     {
                        summary.AppendFormat(" {0}: {1}\r\n", propName, o.ToString());
                     }
                  }
                  summary.Append("\r\n");
               }
               textBoxResults.Text = summary.ToString();
            }
         }
      }
   }
}