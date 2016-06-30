namespace ScrollingDataBinding
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
            this.retrieve = new System.Windows.Forms.Button ();
            this.textName = new System.Windows.Forms.TextBox ();
            this.textQuan = new System.Windows.Forms.TextBox ();
            this.trackBar = new System.Windows.Forms.TrackBar ();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit ();
            this.SuspendLayout ();
            // 
            // retrieve
            // 
            this.retrieve.Location = new System.Drawing.Point (12, 12);
            this.retrieve.Name = "retrieve";
            this.retrieve.Size = new System.Drawing.Size (75, 23);
            this.retrieve.TabIndex = 0;
            this.retrieve.Text = "Retrieve";
            this.retrieve.UseVisualStyleBackColor = true;
            this.retrieve.Click += new System.EventHandler (this.retrieve_Click);
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point (12, 42);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size (268, 20);
            this.textName.TabIndex = 1;
            // 
            // textQuan
            // 
            this.textQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuan.Enabled = false;
            this.textQuan.Location = new System.Drawing.Point (13, 69);
            this.textQuan.Name = "textQuan";
            this.textQuan.Size = new System.Drawing.Size (267, 20);
            this.textQuan.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point (13, 96);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size (267, 45);
            this.trackBar.TabIndex = 3;
            this.trackBar.Scroll += new System.EventHandler (this.trackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (292, 148);
            this.Controls.Add (this.trackBar);
            this.Controls.Add (this.textQuan);
            this.Controls.Add (this.textName);
            this.Controls.Add (this.retrieve);
            this.Name = "Form1";
            this.Text = "10 ScrollingDataBinding";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Button retrieve;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textQuan;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

