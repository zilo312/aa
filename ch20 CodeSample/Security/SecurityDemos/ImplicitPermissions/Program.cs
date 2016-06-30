#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Security.Permissions;

#endregion

namespace ImplicitPermissions
{
	class Program
	{
		static void Main(string[] args)
		{
			CodeAccessPermission permissionA =
			   new FileIOPermission(FileIOPermissionAccess.AllAccess, @"C:\");
			CodeAccessPermission permissionB =
			   new FileIOPermission(FileIOPermissionAccess.Read, @"C:\temp");
			if (permissionB.IsSubsetOf(permissionA))
			{
				Console.WriteLine("PermissionB is a subset of PermissionA");
			}
			else
			{
				Console.WriteLine("PermissionB is NOT a subset of PermissionA");
			}
			Console.ReadLine();

		}
	}
}
