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
  partial class DialogSample : Form
  {
    public DialogSample()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Phone frm = new Phone();

      while (true)
      {
        frm.ShowDialog();
        if (frm.DialogResult == DialogResult.OK)
        {
          label1.Text = "Phone number is " + frm.PhoneNumber;
          if (frm.PhoneNumber.Length == 8 | frm.PhoneNumber.Length == 12)
          {
            break;
          }
          else
          {
            MessageBox.Show("Phone number was not formatted correctly. Please correct entry.");
          }
        }
        else if (frm.DialogResult == DialogResult.Cancel)
        {
          label1.Text = "Form was canceled.";
          break;
        }
      }
      frm.Close();

    }
  }
}