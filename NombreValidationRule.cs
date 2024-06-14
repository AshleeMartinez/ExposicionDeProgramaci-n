
using System.Globalization;

using System.Windows.Controls;

namespace WPFValidacion
{
   
        public class NombreValidationRule : ValidationRule
        {
            public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {
                if (string.IsNullOrWhiteSpace((string)value))
                {
                    return new ValidationResult(false, "El nombre no puede estar vacío.");
                }
                return ValidationResult.ValidResult;
            }
        }
    }




