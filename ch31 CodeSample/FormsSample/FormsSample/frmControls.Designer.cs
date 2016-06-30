namespace FormsSample
{
  partial class frmControls
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControls));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtRoot = new System.Windows.Forms.TextBox();
			this.btnRoot = new System.Windows.Forms.Button();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.errMain = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.button1ToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.button2ToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.button3ToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.addressCtl1 = new FormsSample.SampleControls.AddressCtl();
			this.folderTree1 = new FormsSample.SampleControls.FolderTree();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errMain)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.folderTree1)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "RAIN.ICO");
			this.imageList1.Images.SetKeyName(1, "SNOW.ICO");
			this.imageList1.Images.SetKeyName(2, "SUN.ICO");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 599);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
			this.statusStrip1.Size = new System.Drawing.Size(521, 22);
			this.statusStrip1.TabIndex = 22;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(0, 330);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(521, 272);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dateTimePicker1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(513, 246);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(44, 54);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a label on a tab page.";
			this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
			this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(513, 246);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Second Tab Page";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::FormsSample.Resources.Winter;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(507, 240);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtRoot);
			this.tabPage3.Controls.Add(this.btnRoot);
			this.tabPage3.Controls.Add(this.folderTree1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(513, 246);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Custom Control Sample";
			// 
			// txtRoot
			// 
			this.txtRoot.Location = new System.Drawing.Point(256, 28);
			this.txtRoot.Name = "txtRoot";
			this.txtRoot.Size = new System.Drawing.Size(188, 20);
			this.txtRoot.TabIndex = 2;
			// 
			// btnRoot
			// 
			this.btnRoot.Location = new System.Drawing.Point(256, 65);
			this.btnRoot.Name = "btnRoot";
			this.btnRoot.Size = new System.Drawing.Size(75, 23);
			this.btnRoot.TabIndex = 1;
			this.btnRoot.Text = "Set Root";
			this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(73, 92);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 20);
			this.txtAge.TabIndex = 7;
			this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(75, 119);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(100, 20);
			this.txtZipCode.TabIndex = 8;
			this.txtZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtZipCode_Validating);
			// 
			// errMain
			// 
			this.errMain.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Age:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Zip Code:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(283, 92);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(283, 128);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(80, 17);
			this.checkBox2.TabIndex = 15;
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(75, 156);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 21);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageList = this.imageList1;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button1ToolStripButton,
            this.button2ToolStripButton,
            this.button3ToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(521, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// button1ToolStripButton
			// 
			this.button1ToolStripButton.ImageIndex = 0;
			this.button1ToolStripButton.Name = "button1ToolStripButton";
			this.button1ToolStripButton.Size = new System.Drawing.Size(68, 22);
			this.button1ToolStripButton.Text = "Button 1";
			// 
			// button2ToolStripButton
			// 
			this.button2ToolStripButton.ImageIndex = 1;
			this.button2ToolStripButton.Name = "button2ToolStripButton";
			this.button2ToolStripButton.Size = new System.Drawing.Size(68, 22);
			this.button2ToolStripButton.Text = "Button 2";
			// 
			// button3ToolStripButton
			// 
			this.button3ToolStripButton.ImageIndex = 2;
			this.button3ToolStripButton.Name = "button3ToolStripButton";
			this.button3ToolStripButton.Size = new System.Drawing.Size(68, 22);
			this.button3ToolStripButton.Text = "Button 3";
			// 
			// addressCtl1
			// 
			this.addressCtl1.Location = new System.Drawing.Point(75, 204);
			this.addressCtl1.Name = "addressCtl1";
			this.addressCtl1.Size = new System.Drawing.Size(318, 82);
			this.addressCtl1.TabIndex = 21;
			// 
			// folderTree1
			// 
			this.folderTree1.Location = new System.Drawing.Point(3, 7);
			this.folderTree1.Name = "folderTree1";
			this.folderTree1.Size = new System.Drawing.Size(241, 233);
			this.folderTree1.TabIndex = 0;
			// 
			// frmControls
			// 
			this.ClientSize = new System.Drawing.Size(521, 621);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.addressCtl1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmControls";
			this.Text = "Form3";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errMain)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.folderTree1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

  
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtZipCode;
    private System.Windows.Forms.ErrorProvider errMain;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button btnRoot;
    private System.Windows.Forms.TextBox txtRoot;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton button1ToolStripButton;
    private System.Windows.Forms.ToolStripButton button2ToolStripButton;
    private System.Windows.Forms.ToolStripButton button3ToolStripButton;
    private FormsSample.SampleControls.FolderTree folderTree1;
    private FormsSample.SampleControls.AddressCtl addressCtl1;
		private System.Windows.Forms.StatusStrip statusStrip1;
  }
}