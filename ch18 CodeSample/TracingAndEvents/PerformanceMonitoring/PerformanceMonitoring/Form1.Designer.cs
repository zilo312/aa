namespace PerformanceMonitoring
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.button1 = new System.Windows.Forms.Button();
         this.performanceCounterButtonClicks = new System.Diagnostics.PerformanceCounter();
         this.performanceCounterButtonClicksPerSec = new System.Diagnostics.PerformanceCounter();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.performanceCounterMouseMoveEvents = new System.Diagnostics.PerformanceCounter();
         this.performanceCounterMouseMoveEventsPerSec = new System.Diagnostics.PerformanceCounter();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterButtonClicks)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterButtonClicksPerSec)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterMouseMoveEvents)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterMouseMoveEventsPerSec)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(144, 48);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "Click Me!";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // performanceCounterButtonClicks
         // 
         this.performanceCounterButtonClicks.CategoryName = "Wrox Performance Counts";
         this.performanceCounterButtonClicks.CounterName = "# of Button Clicks";
         this.performanceCounterButtonClicks.ReadOnly = false;
         // 
         // performanceCounterButtonClicksPerSec
         // 
         this.performanceCounterButtonClicksPerSec.CategoryName = "Wrox Performance Counts";
         this.performanceCounterButtonClicksPerSec.CounterName = "# of Button Clicks / sec";
         this.performanceCounterButtonClicksPerSec.ReadOnly = false;
         // 
         // timer1
         // 
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.OnTimer);
         // 
         // performanceCounterMouseMoveEvents
         // 
         this.performanceCounterMouseMoveEvents.CategoryName = "Wrox Performance Counts";
         this.performanceCounterMouseMoveEvents.CounterName = "# of Mouse Move Events";
         this.performanceCounterMouseMoveEvents.ReadOnly = false;
         // 
         // performanceCounterMouseMoveEventsPerSec
         // 
         this.performanceCounterMouseMoveEventsPerSec.CategoryName = "Wrox Performance Counts";
         this.performanceCounterMouseMoveEventsPerSec.CounterName = "# of Mouse Move Events / sec";
         this.performanceCounterMouseMoveEventsPerSec.ReadOnly = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(276, 257);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterButtonClicks)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterButtonClicksPerSec)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterMouseMoveEvents)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.performanceCounterMouseMoveEventsPerSec)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Diagnostics.PerformanceCounter performanceCounterButtonClicks;
      private System.Diagnostics.PerformanceCounter performanceCounterButtonClicksPerSec;
      private System.Windows.Forms.Timer timer1;
      private System.Diagnostics.PerformanceCounter performanceCounterMouseMoveEvents;
      private System.Diagnostics.PerformanceCounter performanceCounterMouseMoveEventsPerSec;
   }
}

