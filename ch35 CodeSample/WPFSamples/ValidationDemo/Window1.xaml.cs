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

namespace ValidationDemo
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      SomeData p1 = new SomeData() { Value1 = 11, Value2 = 22 };

      public Window1()
      {
         InitializeComponent();
         this.DataContext = p1;

      }

      private void buttonSubmit_Click(object sender, RoutedEventArgs e)
      {
         MessageBox.Show(p1.Value1.ToString());

      }
   }
}
