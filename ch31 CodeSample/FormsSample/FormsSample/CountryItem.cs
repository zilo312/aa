using System;

namespace FormsSample
{
	/// <summary>
	/// Summary description for CustomItem.
	/// </summary>
	public class CountryItem	: System.Windows.Forms.ListViewItem
	{
		string _cntryName = "";
		string _cntryAbbrev = "";

		public CountryItem(string countryName, string countryAbbreviation, string currency)
		{
			_cntryName = countryName;
			_cntryAbbrev = countryAbbreviation;
      base.Text = _cntryName;
      base.SubItems.Add(currency);
		}

		public string CountryName
		{
			get	{return _cntryName;}
		}

		public string CountryAbbreviation
		{
			get	{return _cntryAbbrev;}
		}

    
	}
}
