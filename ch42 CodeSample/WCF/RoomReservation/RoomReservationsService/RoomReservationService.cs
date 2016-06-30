using System;
using System.Linq;
using Wrox.ProCSharp.WCF.Data;
using Wrox.ProCSharp.WCF.Entities;

namespace Wrox.ProCSharp.WCF.Services
{

   public class RoomReservationService : IRoomService
   {
      public bool ReserveRoom(RoomReservation roomReservation)
      {
         RoomReservationData data = new RoomReservationData();
         data.ReserveRoom(roomReservation);

         return true;
      }

      public RoomReservation[] GetRoomReservations(DateTime fromDate,
                                                   DateTime toDate)
      {
         RoomReservationData data = new RoomReservationData();
         return data.GetReservations(fromDate, toDate);
      }

   }
}
