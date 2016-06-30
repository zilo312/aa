using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoomReservationClient.RoomService;

namespace RoomReservationClient
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();
      }

      private void OnReserveRoom(object sender, RoutedEventArgs e)
      {
         RoomReservation reservation = new RoomReservation()
         {
            RoomName = textRoom.Text,
            Event = textEvent.Text,
            Contact = textContact.Text,
            StartDate = DateTime.Parse(textStartTime.Text),
            EndDate = DateTime.Parse(textEndTime.Text)
         };

         RoomServiceClient client = new RoomServiceClient();
         client.ReserveRoom(reservation);
         client.Close();
      }
   }
}
