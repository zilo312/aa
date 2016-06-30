using System.Windows;
using System.Windows.Controls;

namespace Wrox.ProCSharp.WPF
{
   public class BookDataTemplateSelector : DataTemplateSelector
   {
      public override DataTemplate SelectTemplate(object item, DependencyObject container)
      {
         if (item != null && item is Book)
         {
            Window window = Application.Current.MainWindow;

            Book book = item as Book;
            switch (book.Publisher)
            {
               case "Wrox Press":
                  return window.FindResource("WroxBookTemplate") as DataTemplate;
               case "Wiley":
                  return window.FindResource("WileyBookTemplate") as DataTemplate;
               default:
                  return window.FindResource("BookTemplate") as DataTemplate;
            }   

         }
         return null;
      }
   }
}
