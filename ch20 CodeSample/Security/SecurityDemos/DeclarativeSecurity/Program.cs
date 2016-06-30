using System.Security.Permissions;


namespace Wrox.ProCSharp.security
{
	class Program
	{
		static void Main()
		{
			MyClass.Method();
		}
	}

	class MyClass
	{
      [FileIOPermission(SecurityAction.Demand, Read="C:/")]
		public static void Method()
		{
			// implementation goes here
		}
	}
}
