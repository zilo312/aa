using System.ServiceModel;

namespace Wrox.ProCSharp.Messaging
{
   public delegate void CourseOrderInfoHandler(CourseOrder courseOrder);

   [ServiceBehavior(UseSynchronizationContext=true)]
   public class CourseOrderService : ICourseOrderService
   {
      public static event CourseOrderInfoHandler CourseOrderAdded;

      #region ICourseOrderService Members
      
      public void AddCourseOrder(CourseOrder courseOrder)
      {
         if (CourseOrderAdded != null)
            CourseOrderAdded(courseOrder);
      }

      #endregion
   }


}
