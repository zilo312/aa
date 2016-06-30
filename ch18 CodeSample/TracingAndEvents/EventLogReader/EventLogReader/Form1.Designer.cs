namespace EventLogReader
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
         this.buttonExit = new System.Windows.Forms.Button();
         this.listBoxEvents = new System.Windows.Forms.ListBox();
         this.eventLog1 = new System.Diagnostics.EventLog();
         ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
         this.SuspendLayout();
         // 
         // buttonExit
         // 
         this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonExit.Location = new System.Drawing.Point(95, 222);
         this.buttonExit.Name = "buttonExit";
         this.buttonExit.Size = new System.Drawing.Size(75, 23);
         this.buttonExit.TabIndex = 0;
         this.buttonExit.Text = "Exit";
         this.buttonExit.UseVisualStyleBackColor = true;
         this.buttonExit.Click += new System.EventHandler(this.OnExit);
         // 
         // listBoxEvents
         // 
         this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listBoxEvents.FormattingEnabled = true;
         this.listBoxEvents.Location = new System.Drawing.Point(13, 13);
         this.listBoxEvents.Name = "listBoxEvents";
         this.listBoxEvents.Size = new System.Drawing.Size(251, 199);
         this.listBoxEvents.TabIndex = 1;
         // 
         // eventLog1
         // 
         this.eventLog1.EnableRaisingEvents = true;
         this.eventLog1.Log = "Application";
         this.eventLog1.SynchronizingObject = this;
         this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.OnEntryWritten);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(276, 257);
         this.Controls.Add(this.listBoxEvents);
         this.Controls.Add(this.buttonExit);
         this.Name = "Form1";
         this.Text = "Event Listener";
         ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button buttonExit;
      private System.Windows.Forms.ListBox listBoxEvents;
      private System.Diagnostics.EventLog eventLog1;
   }
}

