namespace FormsSample
{
  partial class frmListView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
      this.lvCountries = new System.Windows.Forms.ListView();
      this.cbView = new System.Windows.Forms.ComboBox();
      this.imgLarge = new System.Windows.Forms.ImageList(this.components);
      this.imgSmall = new System.Windows.Forms.ImageList(this.components);
      this.lblAbbreviation = new System.Windows.Forms.Label();
      this.SuspendLayout();
// 
// lvCountries
// 
      this.lvCountries.Location = new System.Drawing.Point(36, 91);
      this.lvCountries.Name = "lvCountries";
      this.lvCountries.Size = new System.Drawing.Size(294, 239);
      this.lvCountries.TabIndex = 0;
      this.lvCountries.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvCountries_MouseUp);
// 
// cbView
// 
      this.cbView.FormattingEnabled = true;
      this.cbView.Location = new System.Drawing.Point(36, 38);
      this.cbView.Name = "cbView";
      this.cbView.Size = new System.Drawing.Size(187, 21);
      this.cbView.TabIndex = 1;
      this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbView_SelectedIndexChanged);
// 
// imgLarge
// 
      this.imgLarge.ImageSize = new System.Drawing.Size(48, 48);
      this.imgLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLarge.ImageStream")));
      this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
      this.imgLarge.Images.SetKeyName(0, "");
      this.imgLarge.Images.SetKeyName(1, "");
      this.imgLarge.Images.SetKeyName(2, "");
      this.imgLarge.Images.SetKeyName(3, "");
      this.imgLarge.Images.SetKeyName(4, "");
// 
// imgSmall
// 
      this.imgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
      this.imgSmall.ImageSize = new System.Drawing.Size(16, 16);
      this.imgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmall.ImageStream")));
      this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
      this.imgSmall.Images.SetKeyName(0, "");
      this.imgSmall.Images.SetKeyName(1, "");
      this.imgSmall.Images.SetKeyName(2, "");
      this.imgSmall.Images.SetKeyName(3, "");
      this.imgSmall.Images.SetKeyName(4, "");
// 
// lblAbbreviation
// 
      this.lblAbbreviation.AutoSize = true;
      this.lblAbbreviation.Location = new System.Drawing.Point(251, 44);
      this.lblAbbreviation.Name = "lblAbbreviation";
      this.lblAbbreviation.Size = new System.Drawing.Size(35, 14);
      this.lblAbbreviation.TabIndex = 2;
      this.lblAbbreviation.Text = "label1";
// 
// frmListView
// 
      
      this.ClientSize = new System.Drawing.Size(365, 373);
      this.Controls.Add(this.lblAbbreviation);
      this.Controls.Add(this.cbView);
      this.Controls.Add(this.lvCountries);
      this.Name = "frmListView";
      this.Text = "frmListView";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lvCountries;
    private System.Windows.Forms.ComboBox cbView;
    private System.Windows.Forms.ImageList imgLarge;
    private System.Windows.Forms.ImageList imgSmall;
    private System.Windows.Forms.Label lblAbbreviation;
  }
}