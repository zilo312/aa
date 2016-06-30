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
			   new FileIOPermission(FileIOPermissionAccess.Append,
									@"C:\audit.txt");
			permission.Deny();
			AuditClass.Save("some data to audit");
			CodeAccessPermission.RevertDeny();

			Console.ReadLine();
		}
	}

	class AuditClass
	{
		public static void Save(string value)
		{
			try
			{
				FileIOPermission permission =
				   new FileIOPermission(FileIOPermissionAccess.Append,
										@"C:\audit.txt");
				permission.Assert();
				FileStream stream = new FileStream(@"C:\audit.txt",
				   FileMode.Append, FileAccess.Write);

				// code to write to audit file here...
				CodeAccessPermission.RevertAssert();
				Console.WriteLine("Data written to audit file");
			}
			catch
			{
				Console.WriteLine("Failed to write data to audit file");
			}
		}
	}

}
