using System;
using System.ServiceModel;
using Wrox.ProCSharp.WCF.Services;

namespace Wrox.ProCSharp.WCF
{
   class Program
   {
      internal static ServiceHost myServiceHost = null;

      internal static void StartService()
      {
         myServiceHost = new ServiceHost(typeof(RoomReservationService));
         myServiceHost.Open();
      }

      internal static void StopService()
      {
         if (myServiceHost.State != CommunicationState.Closed)
            myServiceHost.Close();
      }

      static void Main(string[] args)
      {
         StartService();

         Console.WriteLine("Server is running. Press return to exit");
         Console.ReadLine();

         StopService();

      }
   }
}
