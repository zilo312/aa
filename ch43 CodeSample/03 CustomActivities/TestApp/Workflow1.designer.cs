using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace TestApp
{
	partial class Workflow1
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            this.weekday = new System.Workflow.Activities.SequenceActivity();
            this.weekend = new System.Workflow.Activities.SequenceActivity();
            this.daysOfWeekActivity1 = new CustomActivities.DaysOfWeekActivity();
            // 
            // weekday
            // 
            this.weekday.Name = "weekday";
            this.weekday.SetValue(CustomActivities.DaysOfWeekActivity.WeekdayProperty, ((CustomActivities.WeekdayEnum)(((((CustomActivities.WeekdayEnum.Monday | CustomActivities.WeekdayEnum.Tuesday)
                            | CustomActivities.WeekdayEnum.Wednesday)
                            | CustomActivities.WeekdayEnum.Thursday)
                            | CustomActivities.WeekdayEnum.Friday))));
            // 
            // weekend
            // 
            this.weekend.Name = "weekend";
            this.weekend.SetValue(CustomActivities.DaysOfWeekActivity.WeekdayProperty, ((CustomActivities.WeekdayEnum)((CustomActivities.WeekdayEnum.Sunday | CustomActivities.WeekdayEnum.Saturday))));
            // 
            // daysOfWeekActivity1
            // 
            this.daysOfWeekActivity1.Activities.Add(this.weekend);
            this.daysOfWeekActivity1.Activities.Add(this.weekday);
            this.daysOfWeekActivity1.Date = new System.DateTime(2007, 10, 23, 18, 26, 39, 0);
            this.daysOfWeekActivity1.Name = "daysOfWeekActivity1";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.daysOfWeekActivity1);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private SequenceActivity weekday;
        private SequenceActivity weekend;
        private CustomActivities.DaysOfWeekActivity daysOfWeekActivity1;




    }
}
