namespace Wrox.ProCSharp.Delegates
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
         this.buttonRaise = new System.Windows.Forms.Button();
         this.labelInfo = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // buttonRaise
         // 
         this.buttonRaise.Location = new System.Drawing.Point(49, 57);
         this.buttonRaise.Name = "buttonRaise";
         this.buttonRaise.Size = new System.Drawing.Size(75, 23);
         this.buttonRaise.TabIndex = 0;
         this.buttonRaise.Text = "button1";
         this.buttonRaise.UseVisualStyleBackColor = true;
         this.buttonRaise.Click += new System.EventHandler(this.buttonRaise_Click);
         // 
         // labelInfo
         // 
         this.labelInfo.AutoSize = true;
         this.labelInfo.Location = new System.Drawing.Point(49, 135);
         this.labelInfo.Name = "labelInfo";
         this.labelInfo.Size = new System.Drawing.Size(35, 13);
         this.labelInfo.TabIndex = 1;
         this.labelInfo.Text = "label1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(276, 257);
         this.Controls.Add(this.labelInfo);
         this.Controls.Add(this.buttonRaise);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonRaise;
      private System.Windows.Forms.Label labelInfo;
   }
}

