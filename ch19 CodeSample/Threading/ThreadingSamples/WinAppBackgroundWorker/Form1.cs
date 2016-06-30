using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WinAppBackgroundWorker
{
   public struct CalcInput
   {
      public CalcInput(int x, int y)
      {
         this.x = x;
         this.y = y;
      }
      public int x;
      public int y;
   }

   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void OnCalculate(object sender, EventArgs e)
      {
         this.buttonCalculate.Enabled = false;
         this.textBoxResult.Text = String.Empty;
         this.buttonCancel.Enabled = true;
         this.progressBar.Value = 0;
         backgroundWorker.RunWorkerAsync(new CalcInput(
            int.Parse(this.textBoxX.Text), int.Parse(this.textBoxY.Text)));

      }

      //private int Add(int x, int y)
      //{
      //   Thread.Sleep(5000);
      //   return x + y;
      //}

      private void OnDoWork(object sender, DoWorkEventArgs e)
      {
         CalcInput input = (CalcInput)e.Argument;

         for (int i = 0; i < 10; i++)
         {
            Thread.Sleep(500);
            backgroundWorker.ReportProgress(i * 10);
            if (backgroundWorker.CancellationPending)
            {
               e.Cancel = true;
               return;
            }
         }
         
         e.Result = input.x + input.y;
      }

      private void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         if (e.Cancelled)
         {
            this.textBoxResult.Text = "Cancelled";
         }
         else
         {
            this.textBoxResult.Text = e.Result.ToString();
         }
         this.buttonCalculate.Enabled = true;
         this.buttonCancel.Enabled = false;
         this.progressBar.Value = 100;
      }

      private void OnCancel(object sender, EventArgs e)
      {
         backgroundWorker.CancelAsync();
      }

      private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         this.progressBar.Value = e.ProgressPercentage;
      }
   }
}