using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SampleClientApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SampleClient : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Button btnOtherForm;
    private System.Windows.Forms.Label lblOutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SampleClient()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ElementHost host = new ElementHost();
			host.Height = 50;
			host.Dock = DockStyle.Bottom;

			SampleXamlControls.Name name = new SampleXamlControls.Name();

			host.Child = name;
			this.Controls.Add(host);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOtherForm = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOtherForm
			// 
			this.btnOtherForm.Location = new System.Drawing.Point(160, 87);
			this.btnOtherForm.Name = "btnOtherForm";
			this.btnOtherForm.Size = new System.Drawing.Size(92, 23);
			this.btnOtherForm.TabIndex = 0;
			this.btnOtherForm.Text = "Get Date Time";
			this.btnOtherForm.Click += new System.EventHandler(this.btnOtherForm_Click);
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(16, 24);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(412, 56);
			this.lblOutput.TabIndex = 1;
			this.lblOutput.Text = "This is a sample client application. Click the button to see something happen.";
			// 
			// SampleClient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 204);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnOtherForm);
			this.Name = "SampleClient";
			this.Text = "Sample Client";
			this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
    [STAThread]
    static void Main() 
    {
      Application.Run(new SampleClient());
    }

    private void btnOtherForm_Click(object sender, System.EventArgs e)
    {
      this.lblOutput.Text = AppSupport.Support.GetDateTimeInfo(); 
    }
	}
}
