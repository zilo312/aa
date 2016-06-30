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

namespace DynamicResources
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

      private void button2_Click(object sender, RoutedEventArgs e)
      {
         myContainer.Resources.Clear();
         LinearGradientBrush brush = new LinearGradientBrush();
         brush.StartPoint = new Point(0.5, 0);
         brush.EndPoint = new Point(0.5, 1);
         GradientStopCollection stops = new GradientStopCollection();
         stops.Add(new GradientStop(Colors.White, 0.0));
         stops.Add(new GradientStop(Colors.Yellow, 0.14));
         stops.Add(new GradientStop(Colors.YellowGreen, 0.7));
         brush.GradientStops = stops;
         myContainer.Resources.Add("MyGradientBrush", brush);

      }
   }
}
