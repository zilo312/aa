using System;
using System.Workflow.ComponentModel.Design;
using System.Collections.ObjectModel;
using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace CustomActivities
{
    [ActivityDesignerTheme(typeof(DaysOfWeekTheme))]
    public class DaysOfWeekDesigner : ParallelActivityDesigner
    {
        /// <summary>
        /// Ensures that only activities of a certain type can be inserted into the FlagsActivity
        /// </summary>
        /// <param name="insertLocation">The hit test location for the drag & drop or paste operation</param>
        /// <param name="activitiesToInsert">A collection of activities</param>
        /// <returns>True if the activities can be inserted</returns>
        public override bool CanInsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert)
        {
            bool canInsert = true;

            foreach (Activity a in activitiesToInsert)
            {
                if (a.GetType() != typeof(SequenceActivity))
                {
                    canInsert = false;
                    break;
                }
            }

            return canInsert ? canInsert : base.CanInsertActivities(insertLocation, activitiesToInsert);
        }

        /// <summary>
        /// Create a new branch
        /// </summary>
        /// <returns></returns>
        protected override CompositeActivity OnCreateNewBranch()
        {
            return new SequenceActivity();
        }

        /// <summary>
        /// Add an extender provider for the Weekday property
        /// </summary>
        /// <param name="activity"></param>
        protected override void Initialize(Activity activity)
        {
            base.Initialize(activity);

            IExtenderListService iels = base.GetService(typeof(IExtenderListService)) as IExtenderListService;

            if (null != iels)
            {
                bool extenderExists = false;

                foreach (IExtenderProvider provider in iels.GetExtenderProviders())
                {
                    if (provider.GetType() == typeof(WeekdayExtenderProvider))
                    {
                        extenderExists = true;
                        break;
                    }
                }
                if (!extenderExists)
                {
                    IExtenderProviderService ieps = base.GetService(typeof(IExtenderProviderService)) as IExtenderProviderService;
                    if (null != ieps)
                        ieps.AddExtenderProvider(new WeekdayExtenderProvider());
                }
            }
        }

    }
}
