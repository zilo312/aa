#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Text;
using System.Linq;

#endregion

namespace CultureDemo
{
	partial class CultureDemoForm : Form
	{
		public CultureDemoForm()
		{
			InitializeComponent();

			AddCulturesToTree();
		}

		// add all cultures to the tree view
		public void AddCulturesToTree()
		{
			// get all cultures
			CultureInfo[] cultures =
			   CultureInfo.GetCultures(CultureTypes.AllCultures);
            Array.Sort(cultures, (c1, c2) => c1.Name.CompareTo(c2.Name));


			// Array.Sort(cultures, new CultureComparer());
			TreeNode[] nodes = new TreeNode[cultures.Length];

			int i = 0;
			TreeNode parent = null;
			foreach (CultureInfo ci in cultures)
			{
				nodes[i] = new TreeNode();
				nodes[i].Text = ci.DisplayName;
				nodes[i].Tag = ci;

				if (ci.IsNeutralCulture)
				{
					// rembember neutral cultures as parent of the
					// following cultures
					parent = nodes[i];
					treeCultures.Nodes.Add(nodes[i]);
				}
				else if (ci.ThreeLetterISOLanguageName ==
				   CultureInfo.InvariantCulture.ThreeLetterISOLanguageName)
				{
					// invariant cultures don’t have a parent
					treeCultures.Nodes.Add(nodes[i]);
				}
				else
				{
					// specific cultures are added to the neutral parent
					parent.Nodes.Add(nodes[i]);
				}
				i++;
			}
		}

		private void OnSelectCulture(object sender,
				System.Windows.Forms.TreeViewEventArgs e)
		{
			ClearTextFields();

			// get CultureInfo object from tree
			CultureInfo ci = (CultureInfo)e.Node.Tag;

			textName.Text = ci.Name;
			textNativeName.Text = ci.NativeName;
			textEnglishName.Text = ci.EnglishName;

			checkIsNeutral.Checked = ci.IsNeutralCulture;
			// default calendar
            textCalendar.Text = ci.Calendar.ToString().Remove(0, 21).Replace("Calendar", "");

			// fill optional calendars
			listCalendars.Items.Clear();
			foreach (Calendar optCal in ci.OptionalCalendars)
			{
            StringBuilder calName = new StringBuilder(50);
            calName.Append(optCal.ToString());
            calName.Remove(0, 21);
            calName.Replace("Calendar", "");

             //   string calName = optCal.ToString().Remove(0, 21).Replace("Calendar", "");               

				// for GregorianCalendar add type information
            GregorianCalendar gregCal = optCal as GregorianCalendar;
            if (gregCal != null)
				//if (optCal is System.Globalization.GregorianCalendar)
				{
					//GregorianCalendar gregCal = optCal as GregorianCalendar;
					//calName += " " + gregCal.CalendarType.ToString();
               calName.AppendFormat(" {0}", gregCal.CalendarType.ToString());
				}
				listCalendars.Items.Add(calName.ToString());
			}
			// display number and date samples
			if (!ci.IsNeutralCulture)
			{
				groupSamples.Enabled = true;
				ShowSamples(ci);

				// invariant culture doesn't have a region
				if (ci.ThreeLetterISOLanguageName == "IVL")
				{
					groupRegionInformation.Enabled = false;
				}
				else
				{
					groupRegionInformation.Enabled = true;
                    ShowRegionInformation(ci.Name);
//					ShowRegionInformation(ci.LCID);
				}
			}
			else // neutral culture: no region, no number/date formatting
			{
				groupSamples.Enabled = false;
				groupRegionInformation.Enabled = false;
			}
		}

		private void ClearTextFields()
		{
			// samples
			textSampleNumber.Text = "";
			textSampleDate.Text = "";
			textSampleTime.Text = "";

			// region information
			textRegionName.Text = "";
			textCurrency.Text = "";
			textCurrencyName.Text = "";
			checkIsMetric.Checked = false;
		}

		private void ShowSamples(CultureInfo ci)
		{
			double number = 9876543.21;
			textSampleNumber.Text = number.ToString("N", ci);

			DateTime today = DateTime.Today;
			textSampleDate.Text = today.ToString("D", ci);

			DateTime now = DateTime.Now;
			textSampleTime.Text = now.ToString("T", ci);
		}

		private void ShowRegionInformation(string culture)
		{
			RegionInfo ri = new RegionInfo(culture);
			textRegionName.Text = ri.DisplayName;
			textCurrency.Text = ri.CurrencySymbol;
			textCurrencyName.Text = ri.ISOCurrencySymbol;
			checkIsMetric.Checked = ri.IsMetric;
		}

	}

}