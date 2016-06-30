namespace FormsSample.DialogSample
{
  partial class Phone
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
// 
// textBox1
// 
      this.textBox1.Location = new System.Drawing.Point(122, 21);
      this.textBox1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(115, 20);
      this.textBox1.TabIndex = 0;
// 
// label1
// 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 26);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 14);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter phone number:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// btnOK
// 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(36, 65);
      this.btnOK.Name = "btnOK";
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
// 
// btnCancel
// 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(132, 65);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
// 
// Phone
// 
      
      this.ClientSize = new System.Drawing.Size(270, 107);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Phone";
      this.Text = "Phone";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}