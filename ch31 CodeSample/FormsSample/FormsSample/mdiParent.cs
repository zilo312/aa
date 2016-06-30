#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormsSample.SampleControls;

#endregion

namespace FormsSample
{
  partial class mdiParent : Form
  {
 

    public mdiParent()
    {
      InitializeComponent();
      ToolStripControlHost _dateTimeCtl;
      _dateTimeCtl = new ToolStripControlHost(new DateTimePicker());
      ((DateTimePicker)_dateTimeCtl.Control).ValueChanged += delegate { toolStripLabel1.Text = ((DateTimePicker)_dateTimeCtl.Control).Value.Subtract(DateTime.Now).ToString(); };
      _dateTimeCtl.Width = 200;
      _dateTimeCtl.DisplayStyle = ToolStripItemDisplayStyle.Text;
      toolStrip1.Items.Add(_dateTimeCtl);

      DTPickerToolStrip otherDateTimePicker = new DTPickerToolStrip();
      otherDateTimePicker.Width = 200;
      otherDateTimePicker.ValueChanged += new EventHandler(otherDateTimePicker_ValueChanged);
      toolStrip1.Items.Add(otherDateTimePicker);

    }

    private void ShowMdiChild(Form childForm)
    {
      childForm.MdiParent = this;
      childForm.Show();

    }

    private void panelFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowMdiChild(new frmPanel());
    }

    private void listFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowMdiChild(new frmList());
    }

    private void controlsFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowMdiChild(new frmControls());
    }

    private void listViewFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowMdiChild(new frmListView());
    }

    void otherDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
      MessageBox.Show(((DTPickerToolStrip)sender).Value.Subtract(DateTime.Now).ToString());
    }

    private void mdiParent_Load(object sender, EventArgs e)
    {
    
    }

    private void dialogSampleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowMdiChild(new DialogSample.DialogSample());
    }

    private void currentActiveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form currentForm = this.ActiveMdiChild;
      MessageBox.Show(currentForm.Name + " " + currentForm.Text);
    }

    private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }
  }
}