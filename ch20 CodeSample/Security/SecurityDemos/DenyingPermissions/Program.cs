using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace Wrox.ProCSharp.Security
{
   class Program
   {
      static void Main()
      {
         CodeAccessPermission permission =
            new FileIOPermission(FileIOPermissionAccess.AllAccess, @"C:\");
         permission.Deny();
         UntrustworthyClass.Method();
         CodeAccessPermission.RevertDeny();

      }
   }

   class UntrustworthyClass
   {
      public static void Method()
      {
         try
         {
            using (StreamReader reader = File.OpenText(@"C:\textfile.txt"))
            {
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine("Failed to open file {0}", ex.Message);
         }
      }
   }
}
