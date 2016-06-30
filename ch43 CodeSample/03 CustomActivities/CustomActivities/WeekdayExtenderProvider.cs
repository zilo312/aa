using System;
using System.Workflow.Activities;
using System.ComponentModel;
using System.Workflow.ComponentModel;

namespace CustomActivities
{
    [ProvideProperty("Weekday", typeof(SequenceActivity))]
    public class WeekdayExtenderProvider : IExtenderProvider
    {
        bool IExtenderProvider.CanExtend(object extendee)
        {
            bool canExtend = false;

            if ((this != extendee) && (extendee is SequenceActivity))
            {
                Activity parent = ((Activity)extendee).Parent;

                if (null != parent)
                    canExtend = parent is DaysOfWeekActivity;
            }

            return canExtend;
        }

        public WeekdayEnum GetWeekday(Activity activity)
        {
            WeekdayEnum weekday = WeekdayEnum.None;

            Activity parent = activity.Parent;

            if ((null != parent) && (parent is DaysOfWeekActivity))
                weekday = (WeekdayEnum)DaysOfWeekActivity.GetWeekday(activity);

            return weekday;
        }

        public void SetWeekday(Activity activity, WeekdayEnum weekday)
        {
            Activity parent = activity.Parent;

            if ((null != parent) && (parent is DaysOfWeekActivity))
                DaysOfWeekActivity.SetWeekday(activity, weekday);
        }
    }
}
