using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;

namespace AccountManagementSamples
{
   class Program
   {
      static void Main()
      {
         DisplayCurrentUser();
         // CreateUser();
         // ResetPassword();
         // CreateGroup();
         // AddUserToGroup();
         // FindUsers();
         // FindUsers1();
      }

      private static void FindUsers1()
      {
         using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "explorer"))
         using (PrincipalSearchResult<UserPrincipal> users = UserPrincipal.FindByPasswordSetTime(context, DateTime.Today - TimeSpan.FromDays(30), MatchType.LessThan))
         {
            foreach (var user in users)
            {
               Console.WriteLine("{0}, last logon: {1}, last password change: {2}", user.Name, user.LastLogon, user.LastPasswordSet);
            }

         }
      }

      private static void AddUserToGroup()
      {
         using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
         using (GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.Name, "WroxAuthors"))
         using (UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.Name, "Verena Oslzly"))
         {
            group.Members.Add(user);
            group.Save();
         }

      }

      private static void DisplayCurrentUser()
      {
         using (UserPrincipal user = UserPrincipal.Current)
         {
            Console.WriteLine("Context Name: {0}, Container: {1}, Server: {2}", user.Context.Name, user.Context.Container, user.Context.ConnectedServer);
            Console.WriteLine(user.Description);
            Console.WriteLine(user.DisplayName);
            Console.WriteLine(user.EmailAddress);
            Console.WriteLine(user.EmployeeId);
            Console.WriteLine(user.GivenName);
            Console.WriteLine(user.HomeDirectory);
            Console.WriteLine("{0:d}", user.LastLogon);
            Console.WriteLine(user.ScriptPath);
         }

      }

      private static void FindUsers()
      {
         PrincipalContext context = new PrincipalContext(ContextType.Domain);

         UserPrincipal userFilter = new UserPrincipal(context);
         userFilter.Surname = "Nag*";
         userFilter.Enabled = true;

         using (PrincipalSearcher searcher = new PrincipalSearcher())
         {
            searcher.QueryFilter = userFilter;
            PrincipalSearchResult<Principal> searchResult = searcher.FindAll();
            foreach (var user in searchResult)
            {
               Console.WriteLine(user.Name);
            }
         }

      }

      private static void CreateGroup()
      {
         using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, "explorer"))
         using (GroupPrincipal group = new GroupPrincipal(ctx) { Description = "Sample group", DisplayName = "Wrox Authors", Name = "WroxAuthors" })
         {            
            group.Save();
         }
      }

      private static void ResetPassword()
      {
         using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "explorer"))
         using (UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.Name, "Tom"))
         {
            user.SetPassword("Pa$$w0rd");
            user.Save();
         }
      }

      private static void CreateUser()
      {
         using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "explorer"))
         using (UserPrincipal user = new UserPrincipal(context, "Tom", "P@ssw0rd", true) { GivenName = "Tom", EmailAddress = "test@test.com" })
         {
            user.Save();
         }


      }
   }
}
