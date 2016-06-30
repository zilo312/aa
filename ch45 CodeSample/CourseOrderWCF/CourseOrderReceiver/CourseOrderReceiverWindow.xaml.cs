using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.Windows;

namespace Wrox.ProCSharp.Messaging
{

   public partial class CourseOrderReceiverWindow : Window
   {

      private ObservableCollection<CourseOrder> courseOrders = new ObservableCollection<CourseOrder>();

      public CourseOrderReceiverWindow()
      {
         InitializeComponent();

         CourseOrderService.CourseOrderAdded += 
            courseOrder => courseOrders.Add(courseOrder);

         ServiceHost host = new ServiceHost(typeof(CourseOrderService));
         try
         {
            host.Open();
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }

         this.DataContext = courseOrders;


      }

      private void buttonProcessOrder_Click(object sender, RoutedEventArgs e)
      {
         CourseOrder courseOrder = listOrders.SelectedItem as CourseOrder;
         courseOrders.Remove(courseOrder);
         listOrders.SelectedIndex = -1;
         buttonProcessOrder.IsEnabled = false;

         MessageBox.Show("Course order processed", "Course Order Receiver",
            MessageBoxButton.OK, MessageBoxImage.Information);

      }
   }
}
