#region Using directives

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace Wrox.ProCSharp.Localization
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string culture = "";
         if (args.Length == 1)
         {
            culture = args[0];
         }
         else
         {
            culture = "en-US";
         }

			Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BookOfTheDayForm(culture));
		}
	}
}