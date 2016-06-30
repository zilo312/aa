using System;
using System.Collections.Generic;
using System.Text;
using Wrox.ProCSharp.WinServices;

namespace TestQuoteServer
{
    public class Program
    {
        static void Main()
        {
            QuoteServer qs = new QuoteServer(
                  @"c:\ProCSharp\WindowsServices\quotes.txt", 4567);
            qs.Start();
            Console.WriteLine("Hit return to exit");
            Console.ReadLine();
            qs.Stop();
        }
    }
}
