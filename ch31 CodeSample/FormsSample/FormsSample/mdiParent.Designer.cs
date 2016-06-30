namespace FormsSample
{
  partial class mdiParent
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
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.panelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.TabIndex = 5;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      
      this.toolStripLabel1.Text = "Date Sample";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem1
      // 
      this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelToolStripMenuItem,
            this.listToolStripMenuItem,
            this.controlsToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.dialogToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
      
      this.fileToolStripMenuItem1.Text = "File";
      this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
      // 
      // panelToolStripMenuItem
      // 
      this.panelToolStripMenuItem.Name = "panelToolStripMenuItem";
      
      this.panelToolStripMenuItem.Text = "Panel";
      this.panelToolStripMenuItem.Click += new System.EventHandler(this.panelFormToolStripMenuItem_Click);
      // 
      // listToolStripMenuItem
      // 
      this.listToolStripMenuItem.Name = "listToolStripMenuItem";
      
      this.listToolStripMenuItem.Text = "List";
      this.listToolStripMenuItem.Click += new System.EventHandler(this.listFormToolStripMenuItem_Click);
      // 
      // controlsToolStripMenuItem
      // 
      this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
      
      this.controlsToolStripMenuItem.Text = "Controls";
      this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsFormToolStripMenuItem_Click);
      // 
      // listViewToolStripMenuItem
      // 
      this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
      
      this.listViewToolStripMenuItem.Text = "ListView";
      this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewFormToolStripMenuItem_Click);
      // 
      // dialogToolStripMenuItem
      // 
      this.dialogToolStripMenuItem.Name = "dialogToolStripMenuItem";
      
      this.dialogToolStripMenuItem.Text = "Dialog";
      this.dialogToolStripMenuItem.Click += new System.EventHandler(this.dialogSampleToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // mdiParent
      // 
      this.ClientSize = new System.Drawing.Size(619, 345);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "mdiParent";
      this.Text = "mdiParent";
      this.Load += new System.EventHandler(this.mdiParent_Load);
      this.toolStrip1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem panelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dialogToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}