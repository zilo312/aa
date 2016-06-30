#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace FormsSample.DialogSample
{
  partial class Phone : Form
  {
    public Phone()
    {
      InitializeComponent();

      btnOK.DialogResult = DialogResult.OK;
      btnCancel.DialogResult = DialogResult.Cancel;

    }


    public string PhoneNumber
    {
      get { return textBox1.Text; }
      set { textBox1.Text = value; }
    }
  }
}