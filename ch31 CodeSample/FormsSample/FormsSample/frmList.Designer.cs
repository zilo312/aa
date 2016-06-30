namespace FormsSample
{
  partial class frmList
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayCheckedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displaySelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataBindListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AllowMerge = false;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(362, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayCheckedItemsToolStripMenuItem,
            this.displaySelectedItemToolStripMenuItem,
            this.toolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// displayCheckedItemsToolStripMenuItem
			// 
			this.displayCheckedItemsToolStripMenuItem.Name = "displayCheckedItemsToolStripMenuItem";
			this.displayCheckedItemsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.displayCheckedItemsToolStripMenuItem.Text = "Display Checked Items";
			this.displayCheckedItemsToolStripMenuItem.Click += new System.EventHandler(this.displayCheckedItemsToolStripMenuItem_Click);
			// 
			// displaySelectedItemToolStripMenuItem
			// 
			this.displaySelectedItemToolStripMenuItem.Name = "displaySelectedItemToolStripMenuItem";
			this.displaySelectedItemToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.displaySelectedItemToolStripMenuItem.Text = "Display Selected Item";
			this.displaySelectedItemToolStripMenuItem.Click += new System.EventHandler(this.displaySelectedItemToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
			this.toolStripMenuItem1.Text = "Close";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// fillToolStripMenuItem
			// 
			this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dataBindListBoxToolStripMenuItem});
			this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
			this.fillToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
			this.fillToolStripMenuItem.Text = "Fill";
			// 
			// listBoxToolStripMenuItem
			// 
			this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
			this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.listBoxToolStripMenuItem.Text = "List Box";
			this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
			// 
			// checkedListBoxToolStripMenuItem
			// 
			this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
			this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.checkedListBoxToolStripMenuItem.Text = "Checked List Box";
			this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
			// 
			// comboBoxToolStripMenuItem
			// 
			this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
			this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.comboBoxToolStripMenuItem.Text = "Combo Box";
			// 
			// dataBindListBoxToolStripMenuItem
			// 
			this.dataBindListBoxToolStripMenuItem.Name = "dataBindListBoxToolStripMenuItem";
			this.dataBindListBoxToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.dataBindListBoxToolStripMenuItem.Text = "DataBind List Box";
			this.dataBindListBoxToolStripMenuItem.Click += new System.EventHandler(this.dataBindListBoxToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(14, 47);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(124, 186);
			this.listBox1.TabIndex = 19;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(170, 47);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(125, 184);
			this.checkedListBox1.TabIndex = 24;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(163, 272);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(132, 70);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(84, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Load Strings";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(88, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Load Objects";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 261);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "label2";
			// 
			// frmList
			// 
			this.ClientSize = new System.Drawing.Size(362, 354);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "frmList";
			this.Text = "Form2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.ToolStripMenuItem displayCheckedItemsToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.ToolStripMenuItem displaySelectedItemToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolStripMenuItem dataBindListBoxToolStripMenuItem;
  }
}