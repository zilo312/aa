#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace FormsSample
{
  public class Vendor
  {

    string _name;
    string _phone;

    public Vendor()
    {
    }

    public Vendor(string name, string phone)
    {
      _name = name;
      _phone = phone;
    }

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }


    public string Phone
    {
      get { return _phone; }
      set { _phone = value; }
    }


    public override string ToString()
    {
      return _name;
    }

  }
}
