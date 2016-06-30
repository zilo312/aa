namespace UserSearch
{
	partial class UserSearchForm
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
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.buttonSearch = new System.Windows.Forms.Button();
         this.label9 = new System.Windows.Forms.Label();
         this.textBoxFilter = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.listBoxProperties = new System.Windows.Forms.ListBox();
         this.label6 = new System.Windows.Forms.Label();
         this.buttonLoadProperties = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.textBoxPassword = new System.Windows.Forms.TextBox();
         this.textBoxUsername = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textBoxHostname = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxResults = new System.Windows.Forms.TextBox();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
         this.splitContainer1.Panel1.Controls.Add(this.label9);
         this.splitContainer1.Panel1.Controls.Add(this.textBoxFilter);
         this.splitContainer1.Panel1.Controls.Add(this.label8);
         this.splitContainer1.Panel1.Controls.Add(this.label7);
         this.splitContainer1.Panel1.Controls.Add(this.listBoxProperties);
         this.splitContainer1.Panel1.Controls.Add(this.label6);
         this.splitContainer1.Panel1.Controls.Add(this.buttonLoadProperties);
         this.splitContainer1.Panel1.Controls.Add(this.label5);
         this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
         this.splitContainer1.Panel1.Controls.Add(this.textBoxHostname);
         this.splitContainer1.Panel1.Controls.Add(this.label2);
         this.splitContainer1.Panel1.Controls.Add(this.label1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.textBoxResults);
         this.splitContainer1.Size = new System.Drawing.Size(721, 550);
         this.splitContainer1.SplitterDistance = 370;
         this.splitContainer1.TabIndex = 0;
         this.splitContainer1.Text = "splitContainer1";
         // 
         // buttonSearch
         // 
         this.buttonSearch.Location = new System.Drawing.Point(190, 489);
         this.buttonSearch.Name = "buttonSearch";
         this.buttonSearch.Size = new System.Drawing.Size(75, 23);
         this.buttonSearch.TabIndex = 12;
         this.buttonSearch.Text = "Search";
         this.buttonSearch.Click += new System.EventHandler(this.OnSearch);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(22, 489);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(96, 13);
         this.label9.TabIndex = 11;
         this.label9.Text = "5. Start the Search";
         // 
         // textBoxFilter
         // 
         this.textBoxFilter.Location = new System.Drawing.Point(190, 445);
         this.textBoxFilter.Name = "textBoxFilter";
         this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
         this.textBoxFilter.TabIndex = 10;
         this.textBoxFilter.Text = "(objectClass=user)";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(22, 452);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(32, 13);
         this.label8.TabIndex = 9;
         this.label8.Text = "Filter:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(22, 420);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(121, 13);
         this.label7.TabIndex = 8;
         this.label7.Text = "4. Enter the LDAP Filter:";
         // 
         // listBoxProperties
         // 
         this.listBoxProperties.FormattingEnabled = true;
         this.listBoxProperties.Location = new System.Drawing.Point(190, 289);
         this.listBoxProperties.Name = "listBoxProperties";
         this.listBoxProperties.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
         this.listBoxProperties.Size = new System.Drawing.Size(120, 95);
         this.listBoxProperties.TabIndex = 7;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(22, 289);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(126, 26);
         this.label6.TabIndex = 6;
         this.label6.Text = "3. Choose the Properties \r\nto Display";
         // 
         // buttonLoadProperties
         // 
         this.buttonLoadProperties.Location = new System.Drawing.Point(190, 238);
         this.buttonLoadProperties.Name = "buttonLoadProperties";
         this.buttonLoadProperties.Size = new System.Drawing.Size(116, 23);
         this.buttonLoadProperties.TabIndex = 5;
         this.buttonLoadProperties.Text = "Load Properties";
         this.buttonLoadProperties.Click += new System.EventHandler(this.OnLoadProperties);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(29, 238);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(114, 13);
         this.label5.TabIndex = 4;
         this.label5.Text = "2. Load the Properties:";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.textBoxPassword);
         this.groupBox1.Controls.Add(this.textBoxUsername);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Location = new System.Drawing.Point(22, 115);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(304, 100);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Logon [optional]";
         // 
         // textBoxPassword
         // 
         this.textBoxPassword.Location = new System.Drawing.Point(168, 60);
         this.textBoxPassword.Name = "textBoxPassword";
         this.textBoxPassword.PasswordChar = '*';
         this.textBoxPassword.Size = new System.Drawing.Size(116, 20);
         this.textBoxPassword.TabIndex = 3;
         // 
         // textBoxUsername
         // 
         this.textBoxUsername.Location = new System.Drawing.Point(168, 23);
         this.textBoxUsername.Name = "textBoxUsername";
         this.textBoxUsername.Size = new System.Drawing.Size(116, 20);
         this.textBoxUsername.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(7, 60);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(56, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Password:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 29);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Username:";
         // 
         // textBoxHostname
         // 
         this.textBoxHostname.Location = new System.Drawing.Point(190, 70);
         this.textBoxHostname.Name = "textBoxHostname";
         this.textBoxHostname.Size = new System.Drawing.Size(136, 20);
         this.textBoxHostname.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 70);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(136, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Domain Controller [optional]";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 31);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(239, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "1. Enter Domain Controller and Logon Information";
         // 
         // textBoxResults
         // 
         this.textBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxResults.Location = new System.Drawing.Point(0, 0);
         this.textBoxResults.Multiline = true;
         this.textBoxResults.Name = "textBoxResults";
         this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBoxResults.Size = new System.Drawing.Size(347, 550);
         this.textBoxResults.TabIndex = 0;
         // 
         // UserSearchForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(721, 550);
         this.Controls.Add(this.splitContainer1);
         this.Name = "UserSearchForm";
         this.Text = "User Search";
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         this.splitContainer1.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBoxHostname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonLoadProperties;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBoxProperties;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxResults;

	}
}

