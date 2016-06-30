using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace SingletonWinApp
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         bool createdNew;
         Mutex mutex = new Mutex(false, "ProCSharpSingletonWinAppMutex", out createdNew);
         if (!createdNew)
         {
            MessageBox.Show("You can only start one instance of the application");
            Application.Exit();
            return;
         }
         mutex.WaitOne();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1());
      }
   }
}