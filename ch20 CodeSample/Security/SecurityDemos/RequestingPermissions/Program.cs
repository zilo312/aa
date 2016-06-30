using System;
using System.Security.Permissions;


[assembly: UIPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: FileIOPermission(SecurityAction.RequestRefuse, Read = "C:/")]
[assembly: SecurityPermission(SecurityAction.RequestOptional,
     Flags = SecurityPermissionFlag.UnmanagedCode)]


namespace RequestingPermissions
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Demo");

		}
	}
}
