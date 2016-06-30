using System;
using System.Windows;
using System.Windows.Controls;

namespace Wrox.ProCSharp.WPF
{
   class Program
   {
      [STAThread]
      static void Main()
      {        
         Window mainWindow = new Window();
         mainWindow.Title = "WPF Application";
         Button button1 = new Button();
         button1.Content = "Click Me!";
         mainWindow.Content = button1;
         button1.Click += 
            (sender, e) => MessageBox.Show("Button clicked");

         Application app = new Application();
         app.Run(mainWindow);
      }

   }
}
