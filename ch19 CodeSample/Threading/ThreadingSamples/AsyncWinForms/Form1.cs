using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wrox.ProCSharp.Threading;
using System.Threading;

namespace AsyncWinForms
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {

         this.textBox3.Text = Thread.CurrentThread.ManagedThreadId.ToString();
         AsyncComponent c1 = new AsyncComponent();
         c1.LongTaskCompleted += new LongTaskCompletedEventHandler(c1_LongTaskCompleted);
         c1.LongTaskAsync(this.textBox1.Text, 33);

      }

      void c1_LongTaskCompleted(object sender, LongTaskCompletedEventArgs e)
      {
         this.textBox2.Text = e.Output;

         this.textBox4.Text = Thread.CurrentThread.ManagedThreadId.ToString();
      }
   }
}
