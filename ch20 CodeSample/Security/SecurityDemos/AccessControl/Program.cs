using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Wrox.ProCSharp.Security
{
   class Program
   {
      static void DisplayUsage()
      {
           Console.WriteLine("Usage: AccessControl Options Filename");
      }

      static void Main(string[] args)
      {
         string filename = null;
         if (args.Length != 2)
         {
            DisplayUsage();
            return;
         }

         string option = args[0].ToLower();
         filename = args[1];
         switch (option)
         {
            case "-r":
               ReadAcl(filename);
               break;
            case "-w":
               WriteAcl(filename);
               break;
            default:
               DisplayUsage();
               break;
         }
      }

      private static void WriteAcl(string filename)
      {
         NTAccount salesIdentity = new NTAccount("Sales");
         NTAccount developersIdentity = new NTAccount("Developers");
         NTAccount everyOneIdentity = new NTAccount("Everyone");

         FileSystemAccessRule salesAce = new FileSystemAccessRule(salesIdentity, FileSystemRights.Write, AccessControlType.Deny);
         FileSystemAccessRule everyoneAce = new FileSystemAccessRule(everyOneIdentity, FileSystemRights.Read, AccessControlType.Allow);
         FileSystemAccessRule developersAce = new FileSystemAccessRule(developersIdentity, FileSystemRights.FullControl, AccessControlType.Allow);

         FileSecurity securityDescriptor = new FileSecurity();
         securityDescriptor.SetAccessRule(everyoneAce);
         securityDescriptor.SetAccessRule(developersAce);
         securityDescriptor.SetAccessRule(salesAce);

         File.SetAccessControl(filename, securityDescriptor);
      }

      private static void ReadAcl(string filename)
      {
         FileStream stream = File.Open(filename, FileMode.Open);
         FileSecurity securityDescriptor = stream.GetAccessControl();
         AuthorizationRuleCollection rules = securityDescriptor.GetAccessRules(true, true, typeof(NTAccount));
         foreach (AuthorizationRule rule in rules)
         {
            FileSystemAccessRule fileRule = rule as FileSystemAccessRule;
            Console.WriteLine("Access type: {0}", fileRule.AccessControlType);
            Console.WriteLine("Rights: {0}", fileRule.FileSystemRights);
            Console.WriteLine("Identity: {0}", fileRule.IdentityReference.Value);
            Console.WriteLine();
         
         }
         stream.Close();
      }
   }
}
