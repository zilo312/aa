using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleBrowser
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void OnNavigate(object sender, EventArgs e)
      {
         try
         {
            axWebBrowser1.Navigate(toolStripTextUrl.Text);
         }
         catch (COMException ex)
         {
            this.statusStrip.Text = ex.Message;
         }
      }

      private void OnGoBack(object sender, EventArgs e)
      {
         try
         {
            axWebBrowser1.GoBack();
         }
         catch (COMException ex)
         {
            this.statusStrip.Text = ex.Message;
         }

      }

      private void OnGoForward(object sender, EventArgs e)
      {
         try
         {
            axWebBrowser1.GoForward();
         }
         catch (COMException ex)
         {
            this.statusStrip.Text = ex.Message;
         }
      }

      private void OnStatusChange(object sender, AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent e)
      {
         statusStrip.Items[0].Text = e.text;
      }
   }
}
