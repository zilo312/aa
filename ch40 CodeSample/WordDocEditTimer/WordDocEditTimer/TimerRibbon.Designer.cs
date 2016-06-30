namespace WordDocEditTimer
{
   partial class TimerRibbon
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

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncher1 = new Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher();
         this.tab1 = new Microsoft.Office.Tools.Ribbon.RibbonTab();
         this.group1 = new Microsoft.Office.Tools.Ribbon.RibbonGroup();
         this.pauseCheckBox = new Microsoft.Office.Tools.Ribbon.RibbonCheckBox();
         this.toggleDisplayButton = new Microsoft.Office.Tools.Ribbon.RibbonButton();
         this.separator1 = new Microsoft.Office.Tools.Ribbon.RibbonSeparator();
         this.tab1.SuspendLayout();
         this.group1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tab1
         // 
         this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
         this.tab1.ControlId.OfficeId = "TabHome";
         this.tab1.Groups.Add(this.group1);
         this.tab1.Label = "TabHome";
         this.tab1.Name = "tab1";
         // 
         // group1
         // 
         this.group1.DialogLauncher = ribbonDialogLauncher1;
         this.group1.Items.Add(this.toggleDisplayButton);
         this.group1.Items.Add(this.separator1);
         this.group1.Items.Add(this.pauseCheckBox);
         this.group1.Label = "Timer Controls";
         this.group1.Name = "group1";
         this.group1.DialogLauncherClick += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.group1_DialogLauncherClick);
         // 
         // pauseCheckBox
         // 
         this.pauseCheckBox.Label = "Timer paused";
         this.pauseCheckBox.Name = "pauseCheckBox";
         this.pauseCheckBox.Click += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.pauseCheckBox_Click);
         // 
         // toggleDisplayButton
         // 
         this.toggleDisplayButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
         this.toggleDisplayButton.Label = "Toggle Timer Display";
         this.toggleDisplayButton.Name = "toggleDisplayButton";
         this.toggleDisplayButton.OfficeImageId = "StartAfterPrevious";
         this.toggleDisplayButton.ShowImage = true;
         this.toggleDisplayButton.Click += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.toggleDisplayButton_Click);
         // 
         // separator1
         // 
         this.separator1.Name = "separator1";
         // 
         // TimerRibbon
         // 
         this.Name = "TimerRibbon";
         this.RibbonType = "Microsoft.Word.Document";
         this.Tabs.Add(this.tab1);
         this.Load += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs>(this.TimerRibbon_Load);
         this.tab1.ResumeLayout(false);
         this.tab1.PerformLayout();
         this.group1.ResumeLayout(false);
         this.group1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
      internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
      internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox pauseCheckBox;
      internal Microsoft.Office.Tools.Ribbon.RibbonButton toggleDisplayButton;
      internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
   }

   partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection
   {
      internal TimerRibbon TimerRibbon
      {
         get { return this.GetRibbon<TimerRibbon>(); }
      }
   }
}
