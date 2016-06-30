namespace WinAuthenticationServices
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
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.buttonLogin = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textUsername = new System.Windows.Forms.TextBox();
         this.textPassword = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Enabled = false;
         this.button1.Location = new System.Drawing.Point(111, 204);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Enabled = false;
         this.textBox1.Location = new System.Drawing.Point(111, 159);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 1;
         // 
         // buttonLogin
         // 
         this.buttonLogin.Location = new System.Drawing.Point(156, 84);
         this.buttonLogin.Name = "buttonLogin";
         this.buttonLogin.Size = new System.Drawing.Size(75, 23);
         this.buttonLogin.TabIndex = 2;
         this.buttonLogin.Text = "Login";
         this.buttonLogin.UseVisualStyleBackColor = true;
         this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.textPassword);
         this.groupBox1.Controls.Add(this.textUsername);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.buttonLogin);
         this.groupBox1.Location = new System.Drawing.Point(13, 13);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(254, 124);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Authentication";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(58, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Username:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(10, 50);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Password:";
         // 
         // textUsername
         // 
         this.textUsername.Location = new System.Drawing.Point(85, 19);
         this.textUsername.Name = "textUsername";
         this.textUsername.Size = new System.Drawing.Size(128, 20);
         this.textUsername.TabIndex = 5;
         // 
         // textPassword
         // 
         this.textPassword.Location = new System.Drawing.Point(85, 50);
         this.textPassword.Name = "textPassword";
         this.textPassword.PasswordChar = '*';
         this.textPassword.Size = new System.Drawing.Size(128, 20);
         this.textPassword.TabIndex = 6;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 265);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button buttonLogin;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox textPassword;
      private System.Windows.Forms.TextBox textUsername;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}

