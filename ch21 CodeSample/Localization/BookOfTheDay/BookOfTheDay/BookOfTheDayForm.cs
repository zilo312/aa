#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

#endregion

namespace Wrox.ProCSharp.Localization
{
	partial class BookOfTheDayForm : Form
	{
		public BookOfTheDayForm(string culture)
		{
			if (!String.IsNullOrEmpty(culture))
			{
				CultureInfo ci = new CultureInfo(culture);
				// set culture for formatting
				Thread.CurrentThread.CurrentCulture = ci;
				// set culture for resources
				Thread.CurrentThread.CurrentUICulture = ci;
			}


			WelcomeMessage();

			InitializeComponent();

			SetDateAndNumber();
		}

		public static void WelcomeMessage()
		{
			DateTime now = DateTime.Now;
			string message;
			if (now.Hour <= 12)
			{
				message = Properties.Resources.GoodMorning;
			}
			else if (now.Hour <= 19)
			{
				message = Properties.Resources.GoodAfternoon;
			}
			else
			{
				message = Properties.Resources.GoodEvening;
			}
			MessageBox.Show(message + "\n" + 
				Properties.Resources.Message1);
		}

		public void SetDateAndNumber()
		{
			DateTime today = DateTime.Today;
			textDate.Text = today.ToString("D");
			int itemsSold = 327444;
			textItemsSold.Text = itemsSold.ToString("###,###,###");
		}


	}
}