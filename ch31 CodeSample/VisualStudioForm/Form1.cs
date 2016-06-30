#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace VisualStudioForm
{
  partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      System.Diagnostics.Trace.WriteLine(button1.PreferredSize.ToString());
    }
  }
}