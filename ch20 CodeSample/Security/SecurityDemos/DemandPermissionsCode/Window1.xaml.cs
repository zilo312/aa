using System.Security;
using System.Security.Permissions;
using System.Windows;

namespace DemandPermissionsCode
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         try
         {
            FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.AllAccess, @"c:\");
            fileIOPermission.Demand();

         }
         catch (SecurityException)
         {
            button1.IsEnabled = false;

         }
      }
   }
}
