using System;
using System.Security.Principal;
using System.Threading;

namespace Wrox.ProCSharp.Security
{
	class Program
	{
		static void Main()
		{
         //AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.UnauthenticatedPrincipal);
         //GenericIdentity gi = new GenericIdentity("Tom");
         //GenericPrincipal gp = new GenericPrincipal(gi, new string[] { "Employee", "Manager" });
         //Thread.CurrentPrincipal = gp;
         
         AppDomain.CurrentDomain.SetPrincipalPolicy(
            PrincipalPolicy.WindowsPrincipal);

			WindowsPrincipal principal =
			   (WindowsPrincipal)Thread.CurrentPrincipal;
			WindowsIdentity identity = (WindowsIdentity)principal.Identity;
			Console.WriteLine("IdentityType: " + identity.ToString());
			Console.WriteLine("Name: " + identity.Name);

			Console.WriteLine("'Users'?: " + principal.IsInRole("BUILTIN\\Users"));
			Console.WriteLine("'Administrators'?: " +
			   principal.IsInRole(WindowsBuiltInRole.Administrator));
			Console.WriteLine("Authenticated: " + identity.IsAuthenticated);
			Console.WriteLine("AuthType: " + identity.AuthenticationType);
			Console.WriteLine("Anonymous?: " + identity.IsAnonymous);
			Console.WriteLine("Token: " + identity.Token);


		}
	}
}
