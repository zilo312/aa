namespace SimpleExample
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
			this.buttonLoadData = new System.Windows.Forms.Button();
			this.listAnimals = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
// 
// buttonLoadData
// 
			this.buttonLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadData.Location = new System.Drawing.Point(55, 163);
			this.buttonLoadData.Name = "buttonLoadData";
			this.buttonLoadData.TabIndex = 0;
			this.buttonLoadData.Text = "Load Data";
			this.buttonLoadData.Click += new System.EventHandler(this.OnLoadData);
// 
// listAnimals
// 
			this.listAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listAnimals.FormattingEnabled = true;
			this.listAnimals.Location = new System.Drawing.Point(13, 13);
			this.listAnimals.Name = "listAnimals";
			this.listAnimals.Size = new System.Drawing.Size(164, 134);
			this.listAnimals.TabIndex = 1;
// 
// Form1
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(189, 199);
			this.Controls.Add(this.listAnimals);
			this.Controls.Add(this.buttonLoadData);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLoadData;
		private System.Windows.Forms.ListBox listAnimals;
	}
}

