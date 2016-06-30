using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization;
using System.Workflow.Activities;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel;

namespace CustomActivities
{
    /// <summary>
    /// Creates the toolbox item for the FlagsActivity
    /// </summary>
    [Serializable]
    public class DaysOfWeekToolboxItem : ActivityToolboxItem
    {
        /// <summary>
        /// Change the display name
        /// </summary>
        /// <param name="t"></param>
        public DaysOfWeekToolboxItem(Type t)
            : base(t)
        {
            this.DisplayName = "DaysOfWeek";
        }

        /// <summary>
        /// Necessary for the Visual Studio design time environment
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        private DaysOfWeekToolboxItem(SerializationInfo info, StreamingContext context)
        {
            this.Deserialize(info, context);
        }

        /// <summary>
        /// Called when the activity is dragged onto the design surface
        /// </summary>
        /// <remarks>
        /// Here I construct two child activities as well as the FlagsActivity.
        /// </remarks>
        /// <param name="host"></param>
        /// <returns></returns>
        protected override IComponent[] CreateComponentsCore(IDesignerHost host)
        {
            CompositeActivity parent = new DaysOfWeekActivity();
            parent.Activities.Add(new SequenceActivity());
            parent.Activities.Add(new SequenceActivity());

            return new IComponent[] { parent };
        }
    }
}
