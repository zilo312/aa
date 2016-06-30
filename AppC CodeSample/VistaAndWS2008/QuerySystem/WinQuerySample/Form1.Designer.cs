namespace WinQuerySample
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
         this.buttonSearch = new System.Windows.Forms.Button();
         this.textBoxQuery = new System.Windows.Forms.TextBox();
         this.listViewResult = new System.Windows.Forms.ListView();
         this.SuspendLayout();
         // 
         // buttonSearch
         // 
         this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonSearch.Location = new System.Drawing.Point(370, 34);
         this.buttonSearch.Name = "buttonSearch";
         this.buttonSearch.Size = new System.Drawing.Size(75, 23);
         this.buttonSearch.TabIndex = 0;
         this.buttonSearch.Text = "Search";
         this.buttonSearch.UseVisualStyleBackColor = true;
         this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
         // 
         // textBoxQuery
         // 
         this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxQuery.Location = new System.Drawing.Point(22, 34);
         this.textBoxQuery.Name = "textBoxQuery";
         this.textBoxQuery.Size = new System.Drawing.Size(323, 20);
         this.textBoxQuery.TabIndex = 1;
         // 
         // listViewResult
         // 
         this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listViewResult.FullRowSelect = true;
         this.listViewResult.Location = new System.Drawing.Point(12, 76);
         this.listViewResult.Name = "listViewResult";
         this.listViewResult.Size = new System.Drawing.Size(433, 247);
         this.listViewResult.TabIndex = 2;
         this.listViewResult.UseCompatibleStateImageBehavior = false;
         this.listViewResult.View = System.Windows.Forms.View.Details;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(457, 335);
         this.Controls.Add(this.listViewResult);
         this.Controls.Add(this.textBoxQuery);
         this.Controls.Add(this.buttonSearch);
         this.Name = "Form1";
         this.Text = "Search";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonSearch;
      private System.Windows.Forms.TextBox textBoxQuery;
      private System.Windows.Forms.ListView listViewResult;
   }
}

