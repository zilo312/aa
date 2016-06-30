using System.Windows;
using System.Windows.Media;

namespace Wrox.ProCSharp.Assemblies
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


      private void Compile_Click(object sender, RoutedEventArgs e)
      {
         CodeDriverInAppDomain driver = new CodeDriverInAppDomain();
         bool isError;
         textOutput.Text = driver.CompileAndRun(textCode.Text, out isError);
         if (isError)
         {
            textOutput.Background = Brushes.Red;
         }

         
      }
   }
}
