using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.WCF.Data
{
   public class RoomReservation
   {
      public string Room { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public string ContactName { get; set; }
      public string EventName { get; set; }
   }

}
