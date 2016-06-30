using System;
using System.Collections.Generic;
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

namespace Wrox.ProCSharp.WPF
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      private Book book1 = new Book();

      public Window1()
      {
         InitializeComponent();

         book1.Title = "Professional C# 2005 with .NET 3.0";
         book1.Publisher = "Wrox Press";
         book1.Isbn = "978- 0470124727";

         bookGrid.DataContext = book1;


      }

      private void bookButton_Click(object sender, RoutedEventArgs e)
      {
         string message = book1.Title;
         string caption = book1.Isbn;
         MessageBox.Show(message, caption);

      }
   }
}
