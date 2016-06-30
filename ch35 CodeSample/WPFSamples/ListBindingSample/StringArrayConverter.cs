using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace Wrox.ProCSharp.WPF
{
   public class StringArrayConverter : IValueConverter
   {
      #region IValueConverter Members

      public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
      {
         string[] stringCollection = (string[])value;
         string separator = (string)parameter;

         return String.Join(separator, stringCollection);
      }

      public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
      {
         string s = (string)value;
         char separator = (char)parameter;

         return s.Split(separator);
      }

      #endregion
   }
}
