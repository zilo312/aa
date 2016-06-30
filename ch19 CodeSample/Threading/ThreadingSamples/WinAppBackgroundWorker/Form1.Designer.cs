namespace WinAppBackgroundWorker
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
         this.buttonCalculate = new System.Windows.Forms.Button();
         this.textBoxX = new System.Windows.Forms.TextBox();
         this.textBoxY = new System.Windows.Forms.TextBox();
         this.textBoxResult = new System.Windows.Forms.TextBox();
         this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.progressBar = new System.Windows.Forms.ProgressBar();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // buttonCalculate
         // 
         this.buttonCalculate.Location = new System.Drawing.Point(37, 184);
         this.buttonCalculate.Name = "buttonCalculate";
         this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
         this.buttonCalculate.TabIndex = 0;
         this.buttonCalculate.Text = "Calculate";
         this.buttonCalculate.UseVisualStyleBackColor = true;
         this.buttonCalculate.Click += new System.EventHandler(this.OnCalculate);
         // 
         // textBoxX
         // 
         this.textBoxX.Location = new System.Drawing.Point(124, 42);
         this.textBoxX.Name = "textBoxX";
         this.textBoxX.Size = new System.Drawing.Size(82, 20);
         this.textBoxX.TabIndex = 1;
         // 
         // textBoxY
         // 
         this.textBoxY.Location = new System.Drawing.Point(124, 91);
         this.textBoxY.Name = "textBoxY";
         this.textBoxY.Size = new System.Drawing.Size(82, 20);
         this.textBoxY.TabIndex = 2;
         // 
         // textBoxResult
         // 
         this.textBoxResult.Enabled = false;
         this.textBoxResult.Location = new System.Drawing.Point(124, 139);
         this.textBoxResult.Name = "textBoxResult";
         this.textBoxResult.Size = new System.Drawing.Size(82, 20);
         this.textBoxResult.TabIndex = 3;
         // 
         // backgroundWorker
         // 
         this.backgroundWorker.WorkerReportsProgress = true;
         this.backgroundWorker.WorkerSupportsCancellation = true;
         this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnDoWork);
         this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkCompleted);
         this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
         // 
         // buttonCancel
         // 
         this.buttonCancel.Enabled = false;
         this.buttonCancel.Location = new System.Drawing.Point(131, 184);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 4;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         this.buttonCancel.Click += new System.EventHandler(this.OnCancel);
         // 
         // progressBar
         // 
         this.progressBar.Location = new System.Drawing.Point(37, 243);
         this.progressBar.Name = "progressBar";
         this.progressBar.Size = new System.Drawing.Size(169, 23);
         this.progressBar.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(37, 42);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(17, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "X:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(37, 91);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(17, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Y:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(37, 139);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(40, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Result:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(275, 304);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.progressBar);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.textBoxResult);
         this.Controls.Add(this.textBoxY);
         this.Controls.Add(this.textBoxX);
         this.Controls.Add(this.buttonCalculate);
         this.Name = "Form1";
         this.Text = "BackgroundWorker Sample";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonCalculate;
      private System.Windows.Forms.TextBox textBoxX;
      private System.Windows.Forms.TextBox textBoxY;
      private System.Windows.Forms.TextBox textBoxResult;
      private System.ComponentModel.BackgroundWorker backgroundWorker;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}

