using System;
using System.ServiceModel;
using Wrox.ProCSharp.WCF.Entities;


namespace Wrox.ProCSharp.WCF.Services
{
   [ServiceContract]
   public interface IRoomService
   {
      [OperationContract]
      bool ReserveRoom(RoomReservation roomReservation);

      [OperationContract]
      RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate);
   }

}
