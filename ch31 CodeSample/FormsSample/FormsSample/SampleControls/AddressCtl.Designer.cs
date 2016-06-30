namespace FormsSample.SampleControls
{
  partial class AddressCtl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtAddress1 = new System.Windows.Forms.TextBox();
      this.txtAddress2 = new System.Windows.Forms.TextBox();
      this.txtState = new System.Windows.Forms.TextBox();
      this.txtZip = new System.Windows.Forms.TextBox();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
// 
// txtAddress1
// 
      this.txtAddress1.Location = new System.Drawing.Point(102, 4);
      this.txtAddress1.Name = "txtAddress1";
      this.txtAddress1.Size = new System.Drawing.Size(211, 20);
      this.txtAddress1.TabIndex = 0;
// 
// txtAddress2
// 
      this.txtAddress2.Location = new System.Drawing.Point(102, 31);
      this.txtAddress2.Name = "txtAddress2";
      this.txtAddress2.Size = new System.Drawing.Size(211, 20);
      this.txtAddress2.TabIndex = 1;
// 
// txtState
// 
      this.txtState.Location = new System.Drawing.Point(222, 58);
      this.txtState.Name = "txtState";
      this.txtState.Size = new System.Drawing.Size(34, 20);
      this.txtState.TabIndex = 2;
// 
// txtZip
// 
      this.txtZip.Location = new System.Drawing.Point(263, 58);
      this.txtZip.Name = "txtZip";
      this.txtZip.Size = new System.Drawing.Size(50, 20);
      this.txtZip.TabIndex = 3;
// 
// txtCity
// 
      this.txtCity.Location = new System.Drawing.Point(102, 58);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(113, 20);
      this.txtCity.TabIndex = 4;
// 
// label1
// 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 14);
      this.label1.TabIndex = 5;
      this.label1.Text = "Address Line 1";
// 
// label2
// 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 14);
      this.label2.TabIndex = 6;
      this.label2.Text = "Address Line 2";
// 
// label3
// 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 14);
      this.label3.TabIndex = 7;
      this.label3.Text = "City, State && Zip";
// 
// AddressCtl
// 
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCity);
      this.Controls.Add(this.txtZip);
      this.Controls.Add(this.txtState);
      this.Controls.Add(this.txtAddress2);
      this.Controls.Add(this.txtAddress1);
      this.Name = "AddressCtl";
      this.Size = new System.Drawing.Size(318, 82);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtAddress1;
    private System.Windows.Forms.TextBox txtAddress2;
    private System.Windows.Forms.TextBox txtState;
    private System.Windows.Forms.TextBox txtZip;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}
