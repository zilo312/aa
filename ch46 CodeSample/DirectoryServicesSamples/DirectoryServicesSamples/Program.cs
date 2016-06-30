using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices;
using System.Runtime.InteropServices;


namespace DirectoryServicesSamples
{
    class Program
    {
        static void DirectoryEntry()
        {
           try
           {
              using (DirectoryEntry de = new DirectoryEntry())
              {
                 de.Path = "LDAP://treslunas/CN=Christian Nagel, " +
                           "OU=thinktecture, DC=explorer, DC=local";

                 Console.WriteLine("Name: {0}", de.Name);
                 Console.WriteLine("GUID: {0}", de.Guid);
                 Console.WriteLine("Type: {0}", de.SchemaClassName);
                 Console.WriteLine();

                 Console.WriteLine("Properties: ");
                 PropertyCollection properties = de.Properties;
                 foreach (string name in properties.PropertyNames)
                 {
                    foreach (object o in properties[name])
                    {
                       Console.WriteLine("{0}: {1}", name, o.ToString());
                    }
                 }

              }
           }
           catch (COMException ex)
           {
              Console.WriteLine(ex.Message);
           }

        }

        static void RootDSE()
        {
           try
           {
              using (DirectoryEntry de = new DirectoryEntry())
              {
                 de.Path = "LDAP://treslunas/rootDSE";
                 de.Username = @"explorer\chris";
                 de.Password = "password";

                 PropertyCollection props = de.Properties;
                 foreach (string prop in props.PropertyNames)
                 {
                    PropertyValueCollection values = props[prop];
                    foreach (string val in values)
                    {
                       Console.Write("{0}: ", prop);
                       Console.WriteLine(val);
                    }
                 }
              }
           }
           catch (COMException ex)
           {
              Console.WriteLine(ex.Message);
           }
        }

        public static void Children()
        {
            using (DirectoryEntry de = new DirectoryEntry())
            {
                de.Path = "LDAP://treslunas/OU=thinktecture, " +
                          "DC=explorer, DC=local";

                // de.Children.SchemaFilter.Add("user");
                Console.WriteLine("Children of " + de.Name);
                foreach (DirectoryEntry obj in de.Children)
                {
                    Console.WriteLine(obj.Name);
                }
            }
        }

        public static void AddObject()
        {
            DirectoryEntry de = new DirectoryEntry();
            de.Path = "LDAP://treslunas/CN=Users, DC=explorer, DC=local";

            DirectoryEntries users = de.Children;

            DirectoryEntry user = users.Add("CN=John Doe", "user");
            user.Properties["company"].Add("Some Company");
            user.Properties["department"].Add("Sales");
            user.Properties["employeeID"].Add("4711");
            user.Properties["samAccountName"].Add("JDoe");
            user.Properties["userPrincipalName"].Add("JDoe@explorer.local");
            user.Properties["givenName"].Add("John");
            user.Properties["sn"].Add("Doe");
            user.Properties["userPassword"].Add("someSecret");

            user.CommitChanges();
        }

        public static void Search()
        {
            using (DirectoryEntry de =
                new DirectoryEntry("LDAP://treslunas/OU=thinktecture, DC=explorer, DC=local"))
            using (DirectorySearcher searcher = new DirectorySearcher())
            {
                searcher.SearchRoot = de;
                searcher.Filter = "(&(objectClass=user)(description=Auth*))";
                searcher.SearchScope = SearchScope.Subtree;

                searcher.PropertiesToLoad.Add("name");
                searcher.PropertiesToLoad.Add("description");
                searcher.PropertiesToLoad.Add("givenName");
                searcher.PropertiesToLoad.Add("wWWHomePage");

                searcher.Sort = new SortOption("givenName", SortDirection.Ascending);

                SearchResultCollection results = searcher.FindAll();

                foreach (SearchResult result in results)
                {
                    ResultPropertyCollection props = result.Properties;
                    foreach (string propName in props.PropertyNames)
                    {
                        Console.Write("{0}: ", propName);
                        Console.WriteLine(props[propName][0]);
                    }
                    Console.WriteLine();
                }
            }

        }

        static void Main()
        {
           //RootDSE();
           //DirectoryEntry();
           //Children();
           //AddObject();
           Search();

        }



    }
}


