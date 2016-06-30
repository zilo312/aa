#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace FormsSample
{
  partial class frmControls : Form
  {

    /// <summary>
    /// Default constructor. 
    /// </summary>
    public frmControls()
    {
      InitializeComponent();
      
      //Load the combo box with the TextImageRelation enumeration
      comboBox1.Items.Add(TextImageRelation.ImageAboveText);
      comboBox1.Items.Add(TextImageRelation.ImageBeforeText);
      comboBox1.Items.Add(TextImageRelation.Overlay);
      comboBox1.Items.Add(TextImageRelation.TextAboveImage);
      comboBox1.Items.Add(TextImageRelation.TextBeforeImage);
      MenuStrip menu = CreateMenu();
      this.Controls.Add(menu);

//      btnRoot.Click += delegate { folderTree1.RootFolder = txtRoot.Text; };
    }

    private MenuStrip CreateMenu()
    {
      MenuStrip mnu = new MenuStrip();
      ToolStripMenuItem fileMenu = new ToolStripMenuItem();
      fileMenu.Text = "File";
      ToolStripMenuItem fileMenuClose = new ToolStripMenuItem();
      fileMenuClose.Text = "Close";
      fileMenuClose.Click += delegate {this.Close();};
      fileMenu.DropDownItems.Add(fileMenuClose);
      mnu.Items.Add(fileMenu);
			mnu.AllowMerge = false;
      return mnu;
    }

    /// <summary>
    /// Validating event for the txtAge text box.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void txtAge_Validating(object sender, CancelEventArgs e)
    {
      if (txtAge.TextLength > 0 && Convert.ToInt32(txtAge.Text) > 65)
      {
        errMain.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errMain.SetError((Control)sender, "Value must be less then 65.");
        e.Cancel = true;
      }
      else
      {
        errMain.SetError((Control)sender, "");
      }
    }

    /// <summary>
    /// Validating event for the txtZip text box.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void txtZipCode_Validating(object sender, CancelEventArgs e)
    {
      if(txtZipCode.Text.Length != 5)
      {
        errMain.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errMain.SetError((Control)sender, "Must be 5 charactors..");
        e.Cancel = true;

      }
      else
      {
        errMain.SetError((Control)sender, "");
      }
    }

    /// <summary>
    /// MouseEnter event. Raised when thge mouse cursor is inside the region of the control
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void label1_MouseEnter(object sender, EventArgs e)
    {
      ((Label)sender).BackColor = Color.Cyan;
    }

    /// <summary>
    /// MouseLeave event. Raised when the mouse cursor is leaves the control region
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void label1_MouseLeave(object sender, EventArgs e)
    {
      ((Label)sender).BackColor = Color.FromKnownColor(KnownColor.Control);
    }

    /// <summary>
    /// ValueChanged event. Raised when the DateTime value changes.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      label1.Text = ((DateTimePicker)sender).Value.ToString("F");
    }


    /// <summary>
    /// Handles the CheckChanged event of the checkboxes. 
    /// Example of wiring up one handler to handle multiple events from different controls.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void checkBoxChanged(object sender, EventArgs e)
    {
      CheckBox checkBox = (CheckBox)sender;
      MessageBox.Show(checkBox.Name + " new value is " + checkBox.Checked.ToString()); 
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event form the combo box. Applies the selected TextImageRelation
    /// enumeration value to the ToolStripButtons
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach(ToolStripButton toolButton in toolStrip1.Items)
        toolButton.TextImageRelation = (TextImageRelation)comboBox1.SelectedItem;
    }

    private void button1_Click(object sender, EventArgs e)
    {
    
    }

		private void btnRoot_Click(object sender, EventArgs e)
		{
			folderTree1.RootFolder = txtRoot.Text;
		}

    
    
  }
}