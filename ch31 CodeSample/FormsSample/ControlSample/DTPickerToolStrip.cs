#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

#endregion

namespace FormsSample.SampleControls
{
  public class DTPickerToolStrip  : System.Windows.Forms.ToolStripControlHost
  {
    public event EventHandler ValueChanged;

    public DTPickerToolStrip()  : base(new DateTimePicker())
    {
    }

    public new DateTimePicker Control
    {
      get{return (DateTimePicker)base.Control;}
    }

    public DateTime Value
    {
      get { return Control.Value; }
    }


    protected override void OnSubscribeControlEvents(Control control)
    {
      base.OnSubscribeControlEvents(control);
      ((DateTimePicker)control).ValueChanged += new EventHandler(ValueChangedHandler);
    }


    protected override void OnUnsubscribeControlEvents(Control control)
    {
      base.OnSubscribeControlEvents(control);
      ((DateTimePicker)control).ValueChanged -= new EventHandler(ValueChanged);
    }


    private void ValueChangedHandler(object sender, EventArgs e)
    {
      if (ValueChanged != null)
        ValueChanged(this, e);
    }
  }
}
