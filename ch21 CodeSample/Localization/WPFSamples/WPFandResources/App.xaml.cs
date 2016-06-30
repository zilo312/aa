using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace Wrox.ProCSharp.Localization
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {
      public App()
      {
         Wrox.ProCSharp.Localization.Properties.Resources.Culture = new CultureInfo("de-AT");

      }


      private void Application_Startup(object sender, StartupEventArgs e)
      {
         Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

      }
   }
}
