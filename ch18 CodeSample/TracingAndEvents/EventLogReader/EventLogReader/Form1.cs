using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EventLogReader
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void OnEntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
      {
         StringBuilder sb = new StringBuilder();
         sb.AppendFormat("{0} {1} {2}",
            e.Entry.TimeGenerated.ToShortTimeString(),
            e.Entry.Source,
            e.Entry.Message);
         listBoxEvents.Items.Add(sb.ToString());

      }

      private void OnExit(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}