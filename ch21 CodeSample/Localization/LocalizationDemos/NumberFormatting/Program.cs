using System;
using System.Globalization;
using System.Threading;

namespace Wrox.ProCSharp.Localization
{
    class Program
    {
        static void Main()
        {
            int val = 1234567890;

           // for a non-US setting:
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            // culture of the current thread
            Console.WriteLine(val.ToString("N"));

            // use IFormatProvider
            Console.WriteLine(val.ToString("N",
                              new CultureInfo("fr-FR")));

            // change the culture of the thread
            Thread.CurrentThread.CurrentCulture =
                              new CultureInfo("de-DE");
            Console.WriteLine(val.ToString("N"));
        }
    }
}

