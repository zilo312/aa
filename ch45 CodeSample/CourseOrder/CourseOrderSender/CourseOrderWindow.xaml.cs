using System;
using System.Messaging;
using System.Windows;

namespace Wrox.ProCSharp.Messaging
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class CourseOrderWindow : Window
   {
      public CourseOrderWindow()
      {
         InitializeComponent();
      }

      private void buttonSubmit_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            CourseOrder order = new CourseOrder();
            order.Course = new Course() { Title = comboCourses.SelectionBoxItem.ToString() };
            order.Customer = new Customer()
            {
               Company = textCompany.Text,
               Contact = textContact.Text
            };

            string queueName = @".\private$\CourseOrder";
            using (MessageQueue queue = new MessageQueue(queueName))
            using (Message message = new Message(order))
            {
               if (checkHighPrio.IsChecked == true)
               {
                  message.Priority = MessagePriority.High;
               }
               message.Recoverable = true;
               queue.Send(message, String.Format("Course Order {{{0}}}", order.Customer.Company));

            }
            MessageBox.Show("Course order submitted", "Course Order", MessageBoxButton.OK, MessageBoxImage.Information);
         }
         catch (MessageQueueException ex)
         {
            MessageBox.Show(ex.Message, "Course Order Error", MessageBoxButton.OK, MessageBoxImage.Error);
         }

      }
   }
}
