using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace ValidationDemo
{
   public class RegularExpressionValidationRule : ValidationRule
   {
      public string Expression { get; set; }
      public string ErrorMessage { get; set; }

      public override ValidationResult Validate(object value, CultureInfo cultureInfo)
      {
         ValidationResult result = null;
         if (value != null)
         {
            Regex regEx = new Regex(Expression);
            bool isMatch = regEx.IsMatch(value.ToString());
            result = new ValidationResult(isMatch, isMatch ? null : ErrorMessage);
         }
         return result;

      }
   }
}
