using System;
namespace Wrox.ProCSharp.Assemblies.AppDomains
{
   class Program
   {
      static void Main(string[] args)
      {
         AppDomain currentDomain = AppDomain.CurrentDomain;
         Console.WriteLine(currentDomain.FriendlyName);
         AppDomain secondDomain =
               AppDomain.CreateDomain("New AppDomain");
         // secondDomain.ExecuteAssembly("AssemblyA.exe");
         secondDomain.CreateInstance("AssemblyA",
            "Wrox.ProCSharp.Assemblies.AppDomains.Demo", true,
            System.Reflection.BindingFlags.CreateInstance,
            null, new object[] { 7, 3 }, null, null, null);

      }
   }
}

