using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsControl
{
   public partial class UserControl1 : UserControl
   {
      public UserControl1()
      {
         InitializeComponent();
      }

      public string ButtonText
      {
         get { return button1.Text; }
         set { button1.Text = value; }
      }

   }
}
