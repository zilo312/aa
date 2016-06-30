using System.Globalization;

namespace CreateACulture
{
    class Program
    {
        static void Main()
        {
            // Create a Styria culture

            CultureAndRegionInfoBuilder styria = new CultureAndRegionInfoBuilder(
                "de-AT-ST", CultureAndRegionModifiers.None);
            CultureInfo parent = new CultureInfo("de-AT");
            styria.LoadDataFromCultureInfo(parent);
            styria.LoadDataFromRegionInfo(new RegionInfo("AT"));
            styria.Parent = parent;
            styria.RegionNativeName = "Steiermark";
            styria.RegionEnglishName = "Styria";
            styria.CultureEnglishName = "Styria (Austria)";
            styria.CultureNativeName = "Steirisch";

            styria.Register();

            //CultureInfo ci = new CultureInfo("de-AT-ST");
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;

            //ResourceManager rm = new ResourceManager("CreateACulture.Resource1",
            //    Assembly.GetExecutingAssembly());
            //Console.WriteLine(rm.GetString("String1"));


        }
    }
}
