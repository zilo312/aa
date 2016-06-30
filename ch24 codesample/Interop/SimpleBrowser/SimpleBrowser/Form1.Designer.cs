namespace SimpleBrowser
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripTextUrl = new System.Windows.Forms.ToolStripTextBox();
         this.toolStripButtonNavigate = new System.Windows.Forms.ToolStripButton();
         this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
         this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStrip1.SuspendLayout();
         this.statusStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextUrl,
            this.toolStripButtonNavigate,
            this.toolStripButtonBack,
            this.toolStripButtonForward});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(508, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripTextUrl
         // 
         this.toolStripTextUrl.Name = "toolStripTextUrl";
         this.toolStripTextUrl.Size = new System.Drawing.Size(200, 25);
         // 
         // toolStripButtonNavigate
         // 
         this.toolStripButtonNavigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripButtonNavigate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNavigate.Image")));
         this.toolStripButtonNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButtonNavigate.Name = "toolStripButtonNavigate";
         this.toolStripButtonNavigate.Size = new System.Drawing.Size(60, 22);
         this.toolStripButtonNavigate.Text = "Navigate";
         this.toolStripButtonNavigate.Click += new System.EventHandler(this.OnNavigate);
         // 
         // toolStripButtonBack
         // 
         this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
         this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButtonBack.Name = "toolStripButtonBack";
         this.toolStripButtonBack.Size = new System.Drawing.Size(40, 22);
         this.toolStripButtonBack.Text = "Back";
         this.toolStripButtonBack.Click += new System.EventHandler(this.OnGoBack);
         // 
         // toolStripButtonForward
         // 
         this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForward.Image")));
         this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButtonForward.Name = "toolStripButtonForward";
         this.toolStripButtonForward.Size = new System.Drawing.Size(58, 22);
         this.toolStripButtonForward.Text = "Forward";
         this.toolStripButtonForward.Click += new System.EventHandler(this.OnGoForward);
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip.Location = new System.Drawing.Point(0, 412);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Size = new System.Drawing.Size(508, 22);
         this.statusStrip.TabIndex = 1;
         this.statusStrip.Text = "statusStrip1";
         // 
         // axWebBrowser1
         // 
         this.axWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.axWebBrowser1.Enabled = true;
         this.axWebBrowser1.Location = new System.Drawing.Point(0, 25);
         this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
         this.axWebBrowser1.Size = new System.Drawing.Size(508, 387);
         this.axWebBrowser1.TabIndex = 2;
         this.axWebBrowser1.StatusTextChange += new AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler(this.OnStatusChange);
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(508, 434);
         this.Controls.Add(this.axWebBrowser1);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.toolStrip1);
         this.Name = "Form1";
         this.Text = "Simple Browser";
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripTextBox toolStripTextUrl;
      private System.Windows.Forms.ToolStripButton toolStripButtonNavigate;
      private System.Windows.Forms.ToolStripButton toolStripButtonBack;
      private System.Windows.Forms.ToolStripButton toolStripButtonForward;
      private System.Windows.Forms.StatusStrip statusStrip;
      private AxSHDocVw.AxWebBrowser axWebBrowser1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
   }
}

