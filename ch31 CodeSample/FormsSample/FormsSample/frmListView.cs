#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace FormsSample
{
  partial class frmListView : Form
  {
    public frmListView()
    {
      InitializeComponent();

      lvCountries.Items.Add(new CountryItem("United States", "US", "Dollar"));
      lvCountries.Items[0].ImageIndex = 0;
      lvCountries.Items.Add(new CountryItem("Great Britain", "GB", "Pound"));
      lvCountries.Items[1].ImageIndex = 1;
      lvCountries.Items.Add(new CountryItem("Canada", "CA", "Dollar"));
      lvCountries.Items[2].ImageIndex = 2;
      lvCountries.Items.Add(new CountryItem("Japan", "JP", "Yen"));
      lvCountries.Items[3].ImageIndex = 3;
      lvCountries.Items.Add(new CountryItem("Germany", "GM", "Deutch Mark"));
      lvCountries.Items[4].ImageIndex = 4;

      cbView.Items.Add(View.LargeIcon);
      cbView.Items.Add(View.SmallIcon);
      cbView.Items.Add(View.List);
      cbView.Items.Add(View.Details);
      cbView.SelectedIndex = 0;

      lvCountries.Columns.Add("Country", 100, HorizontalAlignment.Left);
      lvCountries.Columns.Add("Currency", 100, HorizontalAlignment.Left);
      lvCountries.LargeImageList = imgLarge;
      lvCountries.SmallImageList = imgSmall;
      lblAbbreviation.Text = "";
    }

    private void cbView_SelectedIndexChanged(object sender, EventArgs e)
    {
      lvCountries.View = (View)cbView.SelectedItem;
    }

    private void lvCountries_MouseUp(object sender, MouseEventArgs e)
    {
      if (lvCountries.View != View.Details)
        lblAbbreviation.Text = ((CountryItem)lvCountries.GetItemAt(e.X, e.Y)).CountryAbbreviation;
      else
        lblAbbreviation.Text = ((CountryItem)lvCountries.GetItemAt(5, e.Y)).CountryAbbreviation;
    }
  }
}