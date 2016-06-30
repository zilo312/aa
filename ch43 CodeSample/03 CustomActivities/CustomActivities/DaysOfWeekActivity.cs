using System;
using System.Workflow.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Workflow.Activities;

namespace CustomActivities
{
    [ToolboxItem(typeof(DaysOfWeekToolboxItem))]
    [Designer(typeof(DaysOfWeekDesigner), typeof(IDesigner))]
    public class DaysOfWeekActivity : CompositeActivity,
        IActivityEventListener<ActivityExecutionStatusChangedEventArgs>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DaysOfWeekActivity()
        {
        }

        /// <summary>
        /// Constructor using a name
        /// </summary>
        /// <param name="name">The name of the activity</param>
        public DaysOfWeekActivity(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Get/Set the day of week property
        /// </summary>
        [Browsable(true)]
        [Category("Behavior")]
        [Description("Bind to a DateTime property, set a specific date time, or leave blank for DateTime.Now")]
        [DefaultValue(typeof(DateTime), "")]
        public DateTime Date
        {
            get { return (DateTime)base.GetValue(DaysOfWeekActivity.DateProperty); }
            set { base.SetValue(DaysOfWeekActivity.DateProperty, value); }
        }

        /// <summary>
        /// Get/Set the IsExecuting flag
        /// </summary>
        private bool IsExecuting
        {
            get { return (bool)base.GetValue(DaysOfWeekActivity.IsExecutingProperty); }
            set { base.SetValue(DaysOfWeekActivity.IsExecutingProperty, value); }
        }

        /// <summary>
        /// Cancel the activity. Loop through all enabled activities, and for any that are currently
        /// executing ask them to cancel.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns>The status of the activity</returns>
        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext)
        {
            if (null == executionContext)
                throw new ArgumentNullException("executionContext");

            bool completed = true;

            for (int pos = 0; pos < base.EnabledActivities.Count; pos++)
            {
                Activity act = base.EnabledActivities[pos];
                if (act.ExecutionStatus == ActivityExecutionStatus.Executing)
                {
                    executionContext.CancelActivity(act);
                    completed = false;
                }
                else if ((act.ExecutionStatus == ActivityExecutionStatus.Canceling) || (act.ExecutionStatus == ActivityExecutionStatus.Faulting))
                    completed = false;
            }
            if (!completed)
                return ActivityExecutionStatus.Canceling;
            else
                return ActivityExecutionStatus.Closed;
        }

        /// <summary>
        /// Execute the activity
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns>Exedcuting if any children are running, otherwise Closed</returns>
        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext)
        {
            if (null == executionContext)
                throw new ArgumentNullException("executionContext");

            this.IsExecuting = true;

            bool executingChildren = false;

            DateTime date = (this.Date == DateTime.MinValue) ? DateTime.Now : this.Date;

            // Get the day of the week from this activity & convert to a WeekdayEnum
            WeekdayEnum weekday = date.DayOfWeek == 0 ? WeekdayEnum.Sunday : (WeekdayEnum)(Convert.ToInt32(Math.Pow(2, (int)date.DayOfWeek)));

            for (int pos = 0; pos < base.EnabledActivities.Count; pos++)
            {
                SequenceActivity act = base.EnabledActivities[pos] as SequenceActivity;

                if (null != act)
                {
                    // Get the attached Weekday property for the activity
                    WeekdayEnum weekdays = (WeekdayEnum)GetWeekday(act);

                    // Now check for a match
                    if ((weekdays & weekday) != WeekdayEnum.None)
                    {
                        executingChildren = true;
                        act.RegisterForStatusChange(Activity.ClosedEvent, this);
                        executionContext.ExecuteActivity(act);
                    }
                }
            }

            return executingChildren ? ActivityExecutionStatus.Executing : ActivityExecutionStatus.Closed;
        }

        /// <summary>
        /// An activity has been added - hookup to that activites Closed event
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="addedActivity"></param>
        protected override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity)
        {
            if (null == executionContext)
                throw new ArgumentNullException("executionContext");
            if (null == addedActivity)
                throw new ArgumentNullException("addedActivity");

            DaysOfWeekActivity act = executionContext.Activity as DaysOfWeekActivity;

            if ((act.ExecutionStatus == ActivityExecutionStatus.Executing) && act.IsExecuting)
            {
                addedActivity.RegisterForStatusChange(Activity.ClosedEvent, this);
                executionContext.ExecuteActivity(addedActivity);
            }
        }

        /// <summary>
        /// Remove the IsExecuting property
        /// </summary>
        /// <param name="provider"></param>
        protected override void OnClosed(IServiceProvider provider)
        {
            base.RemoveProperty(DaysOfWeekActivity.IsExecutingProperty);
        }

        /// <summary>
        /// Called after changes have been made to the Activities collection
        /// </summary>
        /// <param name="rootContext"></param>
        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext rootContext)
        {
            base.OnWorkflowChangesCompleted(rootContext);
            if (this.IsExecuting)
            {
                bool canClose = true;
                for (int pos = 0; pos < base.EnabledActivities.Count; pos++)
                {
                    Activity act = base.EnabledActivities[pos];
                    if (act.ExecutionStatus != ActivityExecutionStatus.Closed)
                    {
                        canClose = false;
                        break;
                    }
                }
                if (canClose)
                    rootContext.CloseActivity();
            }
        }

        /// <summary>
        /// Respond to status changes on child activities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void IActivityEventListener<ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e)
        {
            if (null == sender)
                throw new ArgumentNullException("sender");
            if (null == e)
                throw new ArgumentNullException("e");

            ActivityExecutionContext context = sender as ActivityExecutionContext;
            if (null == context)
                throw new ArgumentException("No execution context is available");

            DaysOfWeekActivity act = context.Activity as DaysOfWeekActivity;
            e.Activity.UnregisterForStatusChange(Activity.ClosedEvent, this);
            bool canClose = true;
            for (int pos = 0; pos < act.EnabledActivities.Count; pos++)
            {
                Activity childAct = act.EnabledActivities[pos];
                if ((childAct.ExecutionStatus != ActivityExecutionStatus.Initialized) && (childAct.ExecutionStatus != ActivityExecutionStatus.Closed))
                {
                    canClose = false;
                    break;
                }
            }
            if (canClose)
                context.CloseActivity();
        }

        /// <summary>
        /// Define a dependency property for the activity which is used to indicate that the activity is executing
        /// </summary>
        private static DependencyProperty IsExecutingProperty =
            DependencyProperty.Register("IsExecuting", typeof(bool), typeof(DaysOfWeekActivity),
            new PropertyMetadata(false));

        /// <summary>
        /// Register the DayOfWeek property
        /// </summary>
        public static DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(DateTime), typeof(DaysOfWeekActivity));

        /// <summary>
        /// Register the Weekday property that is attached to children
        /// </summary>
        public static DependencyProperty WeekdayProperty =
            DependencyProperty.RegisterAttached("Weekday", typeof(WeekdayEnum), typeof(DaysOfWeekActivity),
                new PropertyMetadata(DependencyPropertyOptions.Metadata));

        /// <summary>
        /// Set the weekday on a dependency object
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetWeekday(object dependencyObject, object value)
        {
            if (null == dependencyObject)
                throw new ArgumentNullException("dependencyObject");
            if (null == value)
                throw new ArgumentNullException("value");

            (dependencyObject as DependencyObject).SetValue(DaysOfWeekActivity.WeekdayProperty, value);
        }

        /// <summary>
        /// Get the weekday for a dependency object
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static object GetWeekday(object dependencyObject)
        {
            if (null == dependencyObject)
                throw new ArgumentNullException("dependencyObject");

            return (dependencyObject as DependencyObject).GetValue(DaysOfWeekActivity.WeekdayProperty);
        }

    }
}
