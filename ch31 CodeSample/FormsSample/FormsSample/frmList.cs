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
  partial class frmList : Form
  {
    /// <summary>
    /// Default constructor
    /// </summary>
    public frmList()
    {
      InitializeComponent();
      listBox1.ValueMember = "Phone";
    }

    /// <summary>
    /// Private method to load the list that is pased in as a parameter.
    /// </summary>
    /// <param name="ctrlToLoad"></param>
    private void LoadList(Control ctrlToLoad)
    {
      ListBox tmpCtrl = null;

      if (ctrlToLoad is ListBox)
        tmpCtrl = (ListBox)ctrlToLoad;

      tmpCtrl.DataSource = null;
      tmpCtrl.Items.Clear();
      label1.Text = "";
      label2.Text = "";
      if (radioButton1.Checked)
      {
        //load objects
        tmpCtrl.Items.Add(new Vendor("XYZ Company", "555-555-1234"));
        tmpCtrl.Items.Add(new Vendor("ABC Company", "555-555-2345"));
        tmpCtrl.Items.Add(new Vendor("Other Company", "555-555-3456"));
        tmpCtrl.Items.Add(new Vendor("Another Company", "555-555-4567"));
        tmpCtrl.Items.Add(new Vendor("More Company", "555-555-6789"));
        tmpCtrl.Items.Add(new Vendor("Last Company", "555-555-7890"));
        tmpCtrl.DisplayMember = "Name";
      }
      else
      {
        tmpCtrl.Items.Add("XYZ Company");
        tmpCtrl.Items.Add("ABC Company");
        tmpCtrl.Items.Add("Other Company");
        tmpCtrl.Items.Add("Another Company");
        tmpCtrl.Items.Add("More Company");
        tmpCtrl.Items.Add("Last Company");
      }
    }


    private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadList(listBox1);
    }

    private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadList(checkedListBox1);
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void displayCheckedItemsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string msg = "";

      foreach (object listItem in checkedListBox1.CheckedItems)
      {
        msg += string.Concat( listItem.ToString(), " ");
      }
      MessageBox.Show(msg);
    }

    private void displaySelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show(listBox1.SelectedItem.ToString());
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      label1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
    }

    private void listBox1_SelectedValueChanged(object sender, EventArgs e)
    {
      if(listBox1.SelectedValue != null)
        label2.Text = listBox1.SelectedValue.ToString();
    }

    private void dataBindListBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      listBox1.DataSource = null;
      System.Collections.ArrayList lst = new System.Collections.ArrayList();
      lst.Add(new Vendor("XYZ Company", "555-555-1234"));
      lst.Add(new Vendor("ABC Company", "555-555-2345"));
      lst.Add(new Vendor("Other Company", "555-555-3456"));
      lst.Add(new Vendor("Another Company", "555-555-4567"));
      lst.Add(new Vendor("More Company", "555-555-6789"));
      lst.Add(new Vendor("Last Company", "555-555-7890"));
      listBox1.Items.Clear();
      listBox1.DataSource = lst;
      listBox1.DisplayMember = "Name";
      listBox1.ValueMember = "Phone";
    }
  }
}