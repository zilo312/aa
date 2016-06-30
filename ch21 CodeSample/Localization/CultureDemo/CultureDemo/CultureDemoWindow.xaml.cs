using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Wrox.ProCSharp.Localization
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class CultureDemoWindow : Window
   {
      public CultureDemoWindow()
      {
         InitializeComponent();
         AddCulturesToTree();
      }

      internal void AddCulturesToTree()
      {
         Dictionary<string, TreeViewItem> culturesByName = new Dictionary<string, TreeViewItem>();

         var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

         Array.Sort(cultures, (c1, c2) => c1.DisplayName.CompareTo(c2.DisplayName));

         TreeViewItem[] nodes = new TreeViewItem[cultures.Length];

         int i = 0;
         foreach (var ci in cultures)
         {
            nodes[i] = new TreeViewItem();
            nodes[i].Header = ci.DisplayName;
            nodes[i].Tag = ci;
            culturesByName.Add(ci.Name, nodes[i]);

            TreeViewItem parent;
            if (String.IsNullOrEmpty(ci.Parent.Name) && culturesByName.TryGetValue(ci.Parent.Name, out parent))
            {
               parent.Items.Add(nodes[i]);
            }
            else
            {
               treeCultures.Items.Add(nodes[i]);
            }

            i++;
         }
      }

      private void treeCultures_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
      {
         ClearTextFields();
         CultureInfo ci = (CultureInfo)((TreeViewItem)e.NewValue).Tag;

         textCultureName.Text = ci.Name;
         textNativeName.Text = ci.NativeName;
         textEnglishname.Text = ci.EnglishName;

         chkIsNeutral.IsChecked = ci.IsNeutralCulture;

         textCalendar.Text = ci.Calendar.ToString().Remove(0, 21).Replace("Calendar", "");

         // fill optional calendars
         listCalendars.Items.Clear();
         foreach (var optCal in ci.OptionalCalendars)
         {
            StringBuilder calName = new StringBuilder(50);
            calName.Append(optCal.ToString());
            calName.Remove(0, 21);
            calName.Replace("Calendar", "");

            // for GregorianCalendar add type information
            GregorianCalendar gregCal = optCal as GregorianCalendar;
            if (gregCal != null)
            {
               calName.AppendFormat(" {0}", gregCal.CalendarType.ToString());
            }
            listCalendars.Items.Add(calName.ToString());

            // display number and date samples
            if (!ci.IsNeutralCulture)
            {
               groupSamples.IsEnabled = true;
               ShowSamples(ci);

               // invariant culture doesn't have a region
               if (ci.ThreeLetterISOLanguageName == "IVL")
               {
                  groupRegion.IsEnabled = false;
               }
               else
               {
                  groupRegion.IsEnabled = true;
                  ShowRegionInformation(ci.Name);
               }
            }
            else // neutral culture: no region, no number/date formatting
            {
               groupSamples.IsEnabled = false;
               groupRegion.IsEnabled = false;
            }
         }

      }

      private void ShowRegionInformation(string culture)
      {
         RegionInfo ri = new RegionInfo(culture);
         textRegion.Text = ri.DisplayName;
         textCurrency.Text = ri.CurrencySymbol;
         textCurrencyISO.Text = ri.ISOCurrencySymbol;
         checkIsMetric.IsChecked = ri.IsMetric;
      }

      private void ShowSamples(CultureInfo ci)
      {
         double number = 9876543.21;
         textNumber.Text = number.ToString("N", ci);

         DateTime today = DateTime.Today;
         textDate.Text = today.ToString("D", ci);

         DateTime now = DateTime.Now;
         textTime.Text = now.ToString("T", ci);
      }

      private void ClearTextFields()
      {
         textCultureName.Text = String.Empty;
         textNativeName.Text = String.Empty;
         textEnglishname.Text = String.Empty;

         textCalendar.Text = string.Empty;

         listCalendars.Items.Clear();

         groupSamples.IsEnabled = false;
         textNumber.Text = string.Empty;
         textDate.Text = string.Empty;
         textTime.Text = string.Empty;

         groupRegion.IsEnabled = false;
         textRegion.Text = string.Empty;
         textCurrency.Text = string.Empty;
         textCurrencyISO.Text = string.Empty;



      }

   }
}
