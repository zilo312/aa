using System;
using System.Globalization;
using Wrox.ProCSharp.Localization;

namespace ClientApp
{
    class Program
    {
        static void Main()
        {
            DatabaseResourceManager rm = new DatabaseResourceManager(
                "server=(local);database=LocalizationDemo;trusted_connection=true");

            Console.WriteLine(rm.GetString("Welcome",
                                                  new CultureInfo("es-ES")));
            Console.WriteLine(rm.GetString("ThankYou",
                new CultureInfo("it")));
            Console.WriteLine(rm.GetString("GoodMorning"));

        }
    }
}
