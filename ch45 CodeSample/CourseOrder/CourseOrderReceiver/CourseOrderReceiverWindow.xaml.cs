using System;
using System.Messaging;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Wrox.ProCSharp.Messaging
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class CourseOrderReceiverWindow : Window
   {
      private MessageQueue orderQueue;

      public CourseOrderReceiverWindow()
      {
         InitializeComponent();

         string queueName = @".\private$\CourseOrder";
         orderQueue = new MessageQueue(queueName);
         System.Type[] types = new Type[]
         {
            typeof(CourseOrder),
            typeof(Customer),
            typeof(Course)
         };
         orderQueue.Formatter = new XmlMessageFormatter(types);

         Thread t1 = new Thread(PeekMessages);
         t1.IsBackground = true;
         t1.Start();
       
      }

      private delegate void MethodInvoker(LabelIdMapping labelId);

      private void PeekMessages()
      {
         using (MessageEnumerator messagesEnumerator = orderQueue.GetMessageEnumerator2())
         {
            while (messagesEnumerator.MoveNext(TimeSpan.FromHours(3)))
            {
               LabelIdMapping labelId = new LabelIdMapping() 
               { 
                  Id = messagesEnumerator.Current.Id, 
                  Label = messagesEnumerator.Current.Label 
               };

               Dispatcher.Invoke(DispatcherPriority.Normal, new MethodInvoker(AddListItem),
                  labelId);
            }

            MessageBox.Show("No orders in the last 3 hours. Ending thread",
               "Course Order Receiver", MessageBoxButton.OK, MessageBoxImage.Information);
         }
      }

      private void AddListItem(LabelIdMapping labelIdMapping)
      {
         listOrders.Items.Add(labelIdMapping);
      }

      private class LabelIdMapping
      {
         public string Label { get; set; }
         public string Id { get; set; }

         public override string ToString()
         {
            return Label;
         }
      }

      private void listOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         LabelIdMapping labelId = listOrders.SelectedItem as LabelIdMapping;
         if (labelId == null)
            return;

         orderQueue.MessageReadPropertyFilter.Priority = true;

         Message message = orderQueue.PeekById(labelId.Id);

         CourseOrder order = message.Body as CourseOrder;
         if (order != null)
         {
            textCourse.Text = order.Course.Title;
            textCompany.Text = order.Customer.Company;
            textContact.Text = order.Customer.Contact;
            buttonProcessOrder.IsEnabled = true;

            if (message.Priority > MessagePriority.Normal)
            {
               labelPriority.Visibility = Visibility.Visible;
            }
            else
            {
               labelPriority.Visibility = Visibility.Hidden;
            }
         }
         else
         {
            MessageBox.Show("The selected item is not a course order",
               "Course Order Receiver", MessageBoxButton.OK, MessageBoxImage.Warning);
         }

        

      }

      private void buttonProcessOrder_Click(object sender, RoutedEventArgs e)
      {
         LabelIdMapping labelId = listOrders.SelectedItem as LabelIdMapping;
         Message message = orderQueue.ReceiveById(labelId.Id);

         listOrders.Items.Remove(labelId);
         listOrders.SelectedIndex = -1;
         buttonProcessOrder.IsEnabled = false;
         textCompany.Text = string.Empty;
         textContact.Text = string.Empty;
         textCourse.Text = string.Empty;

         MessageBox.Show("Course order processed", "Course Order Receiver",
            MessageBoxButton.OK, MessageBoxImage.Information);

      }
   }
}
