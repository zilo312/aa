using System;
using System.Globalization;
using System.Threading;


namespace DateFormatting
{
    class Program
    {
        static void Main()
        {
            DateTime d = new DateTime(2008, 02, 14);

            // for a non-US setting:
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


            // current culture
            Console.WriteLine(d.ToLongDateString());

            // use IFormatProvider
            Console.WriteLine(d.ToString("D", new CultureInfo("fr-FR")));

            // use culture of thread
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("{0}: {1}", ci.ToString(), d.ToString("D"));

            ci = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = ci;
            Console.WriteLine("{0: {1}", ci.ToString(), d.ToString("D"));

        }
    }
}
