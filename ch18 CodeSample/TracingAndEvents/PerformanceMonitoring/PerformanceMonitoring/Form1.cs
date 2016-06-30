using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PerformanceMonitoring
{
   public partial class Form1 : Form
   {
      private int clickCountPerSec = 0;
      private int mouseMoveCountPerSec = 0;
      // private int[] mouseMoveCountPerSec = new int[10];
      // private int intervalCounter = 0;

      public Form1()
      {
         InitializeComponent();

         this.timer1.Start();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         performanceCounterButtonClicks.Increment();
         clickCountPerSec++;
      }

      private void OnTimer(object sender, EventArgs e)
      {
         //long oldval = performanceCounterMouseMoveEventsPerSec.RawValue;
         performanceCounterButtonClicksPerSec.RawValue = clickCountPerSec;
         clickCountPerSec = 0;

         // performanceCounterMouseMoveEventsPerSec.RawValue = mouseMoveCountPerSec;
         // mouseMoveCountPerSec = 0;
         int mouseEventCountLastSec = 0;
         //foreach (int val in mouseMoveCountPerSec)
         //{
         //   mouseEventCountLastSec += val;
         //}


         //long oldval = performanceCounterMouseMoveEventsPerSec.RawValue;
         //performanceCounterMouseMoveEventsPerSec.RawValue = mouseEventCountLastSec;

         performanceCounterMouseMoveEventsPerSec.RawValue = mouseMoveCountPerSec;
         mouseMoveCountPerSec = 0;

        // Trace.WriteLine(String.Format("Timer {0} {1} {2}", intervalCounter, mouseEventCountLastSec, oldval));

         //intervalCounter++;
         //if (intervalCounter == 10)
         //   intervalCounter = 0;
         //mouseMoveCountPerSec[intervalCounter] = 0;
      }

      private void OnMouseMove(object sender, MouseEventArgs e)
      {
         performanceCounterMouseMoveEvents.Increment();
         // mouseMoveCountPerSec[intervalCounter]++;
         mouseMoveCountPerSec++;
        // Trace.WriteLine(String.Format("{0} {1}", intervalCounter, mouseMoveCountPerSec[intervalCounter]));
      }


      private void Form1_Load(object sender, EventArgs e)
      {


      }
   }
}

