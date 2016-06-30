using System;
using System.Messaging;

namespace Wrox.ProCSharp.Messaging
{
    class Program
    {
        static void Main()
        {
            foreach (MessageQueue queue in MessageQueue.GetPublicQueues())
            {
                Console.WriteLine(queue.Path);
            }
        }
    }
}

