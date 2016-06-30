namespace CultureDemo
{
	partial class CultureDemoForm
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
         this.treeCultures = new System.Windows.Forms.TreeView();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.textEnglishName = new System.Windows.Forms.TextBox();
         this.textNativeName = new System.Windows.Forms.TextBox();
         this.textCalendar = new System.Windows.Forms.TextBox();
         this.listCalendars = new System.Windows.Forms.ListBox();
         this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
         this.textName = new System.Windows.Forms.TextBox();
         this.checkIsNeutral = new System.Windows.Forms.CheckBox();
         this.groupSamples = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.textSampleNumber = new System.Windows.Forms.TextBox();
         this.textSampleDate = new System.Windows.Forms.TextBox();
         this.textSampleTime = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupRegionInformation = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.textRegionName = new System.Windows.Forms.TextBox();
         this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
         this.textCurrency = new System.Windows.Forms.TextBox();
         this.textCurrencyName = new System.Windows.Forms.TextBox();
         this.checkIsMetric = new System.Windows.Forms.CheckBox();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel6.SuspendLayout();
         this.groupSamples.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.groupRegionInformation.SuspendLayout();
         this.tableLayoutPanel4.SuspendLayout();
         this.tableLayoutPanel5.SuspendLayout();
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
         this.splitContainer1.Panel1.Controls.Add(this.treeCultures);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
         this.splitContainer1.Size = new System.Drawing.Size(546, 472);
         this.splitContainer1.SplitterDistance = 201;
         this.splitContainer1.TabIndex = 0;
         this.splitContainer1.Text = "splitContainer1";
         // 
         // treeCultures
         // 
         this.treeCultures.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeCultures.Location = new System.Drawing.Point(0, 0);
         this.treeCultures.Name = "treeCultures";
         this.treeCultures.Size = new System.Drawing.Size(201, 472);
         this.treeCultures.TabIndex = 0;
         this.treeCultures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnSelectCulture);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.groupSamples, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.groupRegionInformation, 0, 2);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 472);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
         this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
         this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
         this.tableLayoutPanel2.Controls.Add(this.textEnglishName, 1, 1);
         this.tableLayoutPanel2.Controls.Add(this.textNativeName, 1, 2);
         this.tableLayoutPanel2.Controls.Add(this.textCalendar, 1, 3);
         this.tableLayoutPanel2.Controls.Add(this.listCalendars, 1, 4);
         this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 5;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15385F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15385F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 188);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(13, 13);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(74, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Culture Name:";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(12, 52);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(75, 13);
         this.label7.TabIndex = 1;
         this.label7.Text = "English Name:";
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(14, 89);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(72, 13);
         this.label8.TabIndex = 3;
         this.label8.Text = "Native Name:";
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(5, 125);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(89, 13);
         this.label9.TabIndex = 5;
         this.label9.Text = "Default Calendar:";
         // 
         // label10
         // 
         this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(21, 156);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(57, 26);
         this.label10.TabIndex = 7;
         this.label10.Text = "Optional Calendars:";
         // 
         // textEnglishName
         // 
         this.textEnglishName.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textEnglishName.Location = new System.Drawing.Point(157, 48);
         this.textEnglishName.Name = "textEnglishName";
         this.textEnglishName.Size = new System.Drawing.Size(120, 20);
         this.textEnglishName.TabIndex = 2;
         // 
         // textNativeName
         // 
         this.textNativeName.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textNativeName.Location = new System.Drawing.Point(157, 86);
         this.textNativeName.Name = "textNativeName";
         this.textNativeName.Size = new System.Drawing.Size(120, 20);
         this.textNativeName.TabIndex = 4;
         // 
         // textCalendar
         // 
         this.textCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textCalendar.Location = new System.Drawing.Point(157, 122);
         this.textCalendar.Name = "textCalendar";
         this.textCalendar.Size = new System.Drawing.Size(120, 20);
         this.textCalendar.TabIndex = 6;
         // 
         // listCalendars
         // 
         this.listCalendars.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.listCalendars.FormattingEnabled = true;
         this.listCalendars.Location = new System.Drawing.Point(157, 160);
         this.listCalendars.Name = "listCalendars";
         this.listCalendars.Size = new System.Drawing.Size(120, 17);
         this.listCalendars.TabIndex = 8;
         // 
         // tableLayoutPanel6
         // 
         this.tableLayoutPanel6.ColumnCount = 2;
         this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
         this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
         this.tableLayoutPanel6.Controls.Add(this.textName, 0, 0);
         this.tableLayoutPanel6.Controls.Add(this.checkIsNeutral, 1, 0);
         this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel6.Location = new System.Drawing.Point(103, 3);
         this.tableLayoutPanel6.Name = "tableLayoutPanel6";
         this.tableLayoutPanel6.RowCount = 1;
         this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         this.tableLayoutPanel6.Size = new System.Drawing.Size(229, 33);
         this.tableLayoutPanel6.TabIndex = 19;
         // 
         // textName
         // 
         this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textName.Location = new System.Drawing.Point(3, 6);
         this.textName.Name = "textName";
         this.textName.Size = new System.Drawing.Size(68, 20);
         this.textName.TabIndex = 0;
         // 
         // checkIsNeutral
         // 
         this.checkIsNeutral.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.checkIsNeutral.AutoSize = true;
         this.checkIsNeutral.Location = new System.Drawing.Point(116, 8);
         this.checkIsNeutral.Name = "checkIsNeutral";
         this.checkIsNeutral.Size = new System.Drawing.Size(71, 17);
         this.checkIsNeutral.TabIndex = 1;
         this.checkIsNeutral.Text = "Is Neutral";
         // 
         // groupSamples
         // 
         this.groupSamples.Controls.Add(this.tableLayoutPanel3);
         this.groupSamples.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupSamples.Location = new System.Drawing.Point(3, 197);
         this.groupSamples.Name = "groupSamples";
         this.groupSamples.Size = new System.Drawing.Size(335, 133);
         this.groupSamples.TabIndex = 1;
         this.groupSamples.TabStop = false;
         this.groupSamples.Text = "Samples";
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel3.Controls.Add(this.textSampleNumber, 1, 0);
         this.tableLayoutPanel3.Controls.Add(this.textSampleDate, 1, 1);
         this.tableLayoutPanel3.Controls.Add(this.textSampleTime, 1, 2);
         this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 3;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(329, 114);
         this.tableLayoutPanel3.TabIndex = 0;
         // 
         // textSampleNumber
         // 
         this.textSampleNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textSampleNumber.Location = new System.Drawing.Point(154, 8);
         this.textSampleNumber.Name = "textSampleNumber";
         this.textSampleNumber.Size = new System.Drawing.Size(120, 20);
         this.textSampleNumber.TabIndex = 1;
         // 
         // textSampleDate
         // 
         this.textSampleDate.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textSampleDate.Location = new System.Drawing.Point(154, 45);
         this.textSampleDate.Name = "textSampleDate";
         this.textSampleDate.Size = new System.Drawing.Size(120, 20);
         this.textSampleDate.TabIndex = 3;
         // 
         // textSampleTime
         // 
         this.textSampleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textSampleTime.Location = new System.Drawing.Point(154, 84);
         this.textSampleTime.Name = "textSampleTime";
         this.textSampleTime.Size = new System.Drawing.Size(120, 20);
         this.textSampleTime.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(26, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(47, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Number:";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(24, 49);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(52, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Full Date:";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(33, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(33, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Time:";
         // 
         // groupRegionInformation
         // 
         this.groupRegionInformation.Controls.Add(this.tableLayoutPanel4);
         this.groupRegionInformation.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupRegionInformation.Location = new System.Drawing.Point(3, 336);
         this.groupRegionInformation.Name = "groupRegionInformation";
         this.groupRegionInformation.Size = new System.Drawing.Size(335, 133);
         this.groupRegionInformation.TabIndex = 2;
         this.groupRegionInformation.TabStop = false;
         this.groupRegionInformation.Text = "Region Information";
         // 
         // tableLayoutPanel4
         // 
         this.tableLayoutPanel4.ColumnCount = 2;
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
         this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
         this.tableLayoutPanel4.Controls.Add(this.textRegionName, 1, 0);
         this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
         this.tableLayoutPanel4.Controls.Add(this.checkIsMetric, 1, 2);
         this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
         this.tableLayoutPanel4.Name = "tableLayoutPanel4";
         this.tableLayoutPanel4.RowCount = 3;
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
         this.tableLayoutPanel4.Size = new System.Drawing.Size(329, 114);
         this.tableLayoutPanel4.TabIndex = 0;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(28, 12);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(44, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Region:";
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(24, 49);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(52, 13);
         this.label5.TabIndex = 2;
         this.label5.Text = "Currency:";
         // 
         // textRegionName
         // 
         this.textRegionName.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textRegionName.Location = new System.Drawing.Point(154, 8);
         this.textRegionName.Name = "textRegionName";
         this.textRegionName.Size = new System.Drawing.Size(120, 20);
         this.textRegionName.TabIndex = 1;
         // 
         // tableLayoutPanel5
         // 
         this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.tableLayoutPanel5.ColumnCount = 2;
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel5.Controls.Add(this.textCurrency, 0, 0);
         this.tableLayoutPanel5.Controls.Add(this.textCurrencyName, 1, 0);
         this.tableLayoutPanel5.Location = new System.Drawing.Point(143, 43);
         this.tableLayoutPanel5.Name = "tableLayoutPanel5";
         this.tableLayoutPanel5.RowCount = 1;
         this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
         this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
         this.tableLayoutPanel5.Size = new System.Drawing.Size(142, 24);
         this.tableLayoutPanel5.TabIndex = 3;
         // 
         // textCurrency
         // 
         this.textCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textCurrency.Location = new System.Drawing.Point(3, 3);
         this.textCurrency.Name = "textCurrency";
         this.textCurrency.Size = new System.Drawing.Size(56, 20);
         this.textCurrency.TabIndex = 0;
         // 
         // textCurrencyName
         // 
         this.textCurrencyName.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.textCurrencyName.Location = new System.Drawing.Point(65, 3);
         this.textCurrencyName.Name = "textCurrencyName";
         this.textCurrencyName.Size = new System.Drawing.Size(74, 20);
         this.textCurrencyName.TabIndex = 1;
         // 
         // checkIsMetric
         // 
         this.checkIsMetric.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.checkIsMetric.AutoSize = true;
         this.checkIsMetric.Location = new System.Drawing.Point(181, 85);
         this.checkIsMetric.Name = "checkIsMetric";
         this.checkIsMetric.Size = new System.Drawing.Size(66, 17);
         this.checkIsMetric.TabIndex = 4;
         this.checkIsMetric.Text = "Is Metric";
         // 
         // CultureDemoForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(546, 472);
         this.Controls.Add(this.splitContainer1);
         this.Name = "CultureDemoForm";
         this.Text = "Culture Demo";
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.tableLayoutPanel6.ResumeLayout(false);
         this.tableLayoutPanel6.PerformLayout();
         this.groupSamples.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel3.PerformLayout();
         this.groupRegionInformation.ResumeLayout(false);
         this.tableLayoutPanel4.ResumeLayout(false);
         this.tableLayoutPanel4.PerformLayout();
         this.tableLayoutPanel5.ResumeLayout(false);
         this.tableLayoutPanel5.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupSamples;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox textSampleNumber;
		private System.Windows.Forms.TextBox textSampleDate;
		private System.Windows.Forms.TextBox textSampleTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupRegionInformation;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textRegionName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TextBox textCurrency;
		private System.Windows.Forms.TextBox textCurrencyName;
		private System.Windows.Forms.CheckBox checkIsMetric;
		private System.Windows.Forms.TextBox textEnglishName;
		private System.Windows.Forms.TextBox textNativeName;
		private System.Windows.Forms.TextBox textCalendar;
		private System.Windows.Forms.ListBox listCalendars;
		private System.Windows.Forms.TreeView treeCultures;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.CheckBox checkIsNeutral;
	}
}

