using System.EnterpriseServices;
using System.Runtime.InteropServices;

[assembly: ApplicationName("Wrox EnterpriseDemo")]
[assembly: Description("Wrox Sample Application for Professional C#")]
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(false)]


namespace Wrox.ProCSharp.EnterpriseServices
{
   [ComVisible(true)]
   public interface IGreeting
   {
      string Welcome(string name);
   }

   [EventTrackingEnabled(true)]
   [ComVisible(true)]
   [Description("Simple Serviced Component Sample")]
   public class SimpleComponent : ServicedComponent, IGreeting
   {
      public SimpleComponent()
      {
      }

      public string Welcome(string name)
      {
         // simulate some processing time
         System.Threading.Thread.Sleep(1000);
         return "Hello, " + name;
      }
   }

}
