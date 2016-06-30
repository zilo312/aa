using System;
using System.Linq;
using System.Collections.Generic;
using Wrox.ProCSharp.WCF.Entities;

namespace Wrox.ProCSharp.WCF.Data
{
   public class RoomReservationData
   {
      public void ReserveRoom(RoomReservation roomReservation)
      {
         using (RoomReservationDataContext data = new RoomReservationDataContext())
         {
            data.RoomReservations.InsertOnSubmit(roomReservation);
            data.SubmitChanges();
         }
      }

      public RoomReservation[] GetReservations(DateTime fromDate, DateTime toDate)
      {
         using (RoomReservationDataContext data = new RoomReservationDataContext())
         {
            return (from r in data.RoomReservations
                    where r.StartDate > fromDate && r.EndDate < toDate
                    select r).ToArray();
         }
      }

   }
}
