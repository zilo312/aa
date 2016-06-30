using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Workflow.ComponentModel.Design;

namespace CustomActivities
{
    public class DaysOfWeekTheme : CompositeDesignerTheme
    {
        /// <summary>
        /// Define the properties of the theme
        /// </summary>
        /// <param name="theme"></param>
        public DaysOfWeekTheme(WorkflowTheme theme)
            : base(theme)
        {
            this.ShowDropShadow = false;
            this.ConnectorStartCap = LineAnchor.None;
            this.ConnectorEndCap = LineAnchor.None;
            this.ForeColor = Color.FromArgb(0xff, 0x80, 0, 0x80);
            this.BorderColor = Color.FromArgb(0xff, 0xe0, 0xe0, 0xe0);
            this.BorderStyle = DashStyle.Dash;
        }
    }
}
