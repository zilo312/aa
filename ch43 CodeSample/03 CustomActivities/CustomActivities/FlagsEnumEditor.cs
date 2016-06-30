using System;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace CustomActivities
{
    public class FlagsEnumEditor : UITypeEditor
    {
        // The checklistbox
        private FlagCheckedListBox flagEnumCB;

        public FlagsEnumEditor()
        {
            flagEnumCB = new FlagCheckedListBox();
            flagEnumCB.BorderStyle = BorderStyle.None;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context != null
                && context.Instance != null
                && provider != null)
            {

                IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                if (edSvc != null)
                {

                    Enum e = (Enum)Convert.ChangeType(value, context.PropertyDescriptor.PropertyType);
                    flagEnumCB.EnumValue = e;
                    edSvc.DropDownControl(flagEnumCB);
                    return flagEnumCB.EnumValue;

                }
            }
            return null;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }
    }
}
