#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

#endregion

namespace FormsSample.SampleControls
{
  public partial class AddressCtl : UserControl
  {
    public event EventHandler AddressLine1Changed;
    public event EventHandler AddressLine2Changed;
    public event EventHandler CityChanged;
    public event EventHandler StateChanged;
    public event EventHandler ZipChanged;

    public AddressCtl()
    {
      InitializeComponent();
      txtAddress1.TextChanged += new EventHandler(controls_TextChanged);
      txtAddress2.TextChanged += new EventHandler(controls_TextChanged);
      txtCity.TextChanged += new EventHandler(controls_TextChanged);
      txtState.TextChanged += new EventHandler(controls_TextChanged);
      txtZip.TextChanged += new EventHandler(controls_TextChanged);
    }


    private void controls_TextChanged(object sender, System.EventArgs e)
    {
      switch(((TextBox)sender).Name)
      {
        case "txtAddress1":
          if (AddressLine1Changed != null)
            AddressLine1Changed(this, EventArgs.Empty);

          break;
        case "txtAddress2":
          if (AddressLine2Changed != null)
            AddressLine2Changed(this, EventArgs.Empty);

          break;
        case "txtCity":
          if (CityChanged != null)
            CityChanged(this, EventArgs.Empty);

          break;
        case "txtState":
          if (StateChanged != null)
            StateChanged(this, EventArgs.Empty);

          break;
        case "txtZip":
          if (ZipChanged != null)
            ZipChanged(this, EventArgs.Empty);

          break;

      }
    }


    [Category("AddressData"),
    Description("Gets or sets the AddressLine1 value"),
    DefaultValue("")]
    public string AddressLine1
    {
      get { return txtAddress1.Text; }
      set
      {
        if (txtAddress1.Text != value)
        {
          txtAddress1.Text = value;
          if (AddressLine1Changed != null)
            AddressLine1Changed(this, EventArgs.Empty);
        }
      }
    }

    [Category("AddressData"),
    Description("Gets or sets the AddressLine2 value"),
    DefaultValue("")]
    public string AddressLine2
    {
      get { return txtAddress2.Text; }
      set
      {
        if (txtAddress2.Text != value)
        {
          txtAddress2.Text = value;
          if (AddressLine2Changed != null)
            AddressLine2Changed(this, EventArgs.Empty);
        }
      }
    }

    [Category("AddressData"),
    Description("Gets or sets the City value"),
    DefaultValue("")]
    public string City
    {
      get { return txtCity.Text; }
      set
      {
        if (txtCity.Text != value)
        {
          txtCity.Text = value;
          if (CityChanged != null)
            CityChanged(this, EventArgs.Empty);
        }
      }
    }


    [Category("AddressData"),
    Description("Gets or sets the State value"),
    DefaultValue("")]
    public string State
    {
      get { return txtState.Text; }
      set
      {
        if (txtState.Text != value)
        {
          txtState.Text = value;
          if (StateChanged != null)
            StateChanged(this, EventArgs.Empty);
        }
      }
    }


    [Category("AddressData"),
    Description("Gets or sets the Zip value"),
    DefaultValue("")]
    public string Zip
    {
      get { return txtZip.Text; }
      set
      {
        if (txtZip.Text != value)
        {
          txtZip.Text = value;
          if (ZipChanged != null)
            ZipChanged(this, EventArgs.Empty);
        }
      }
    }


  }
}
