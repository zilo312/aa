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
using System.Web.Security;
using System.Net;

namespace AuthenticationServices
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

      private void buttonLogin_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            if (Membership.ValidateUser(textUsername.Text, textPassword.Password))
            {
               // user validated!
               labelValidatedInfo.Visibility = Visibility.Visible;
            }
            else
            {
               MessageBox.Show("Username or password not valid", "Client Authentication Services", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
         }
         catch (WebException ex)
         {
            MessageBox.Show(ex.Message, "Client Application Services", MessageBoxButton.OK, MessageBoxImage.Error);            
         }

         

      }
   }
}
