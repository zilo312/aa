using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Wrox.ProCSharp.WCF
{
   class ClientCallback : IMyMessageCallback
   {
      public void OnCallback(string message)
      {
         Console.WriteLine("message from the server: {0}", message);
      }
   }


   class Program
   {
      static void Main()
      {
         Console.WriteLine("Client - wait for service");
         Console.ReadLine();

         WSDualHttpBinding binding = new WSDualHttpBinding();
         EndpointAddress address =
               new EndpointAddress("http://localhost:8731/Design_Time_Addresses/MessageService/Service1/");

         ClientCallback clientCallback = new ClientCallback();
         InstanceContext context = new InstanceContext(clientCallback);

         DuplexChannelFactory<IMyMessage> factory =
            new DuplexChannelFactory<IMyMessage>(context, binding, address);

         IMyMessage messageChannel = factory.CreateChannel();

         messageChannel.MessageToServer("From the client");

         Console.WriteLine("Client - press return to exit");
         Console.ReadLine();

      }
   }
}
