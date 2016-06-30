using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Globalization;
using System.Threading;

namespace Wrox.ProCSharp.Localization
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {

      public App()
      {
         Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-AT");
      }
   }
}
