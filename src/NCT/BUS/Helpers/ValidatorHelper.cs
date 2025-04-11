using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BUS.Helpers
{
    public static class ValidatorHelper
    {
        public static bool TryValidateAllErrors(object instance, out List<string> errors)
        {
            errors = new List<string>();
            if (instance == null) return false;

            var context = new ValidationContext(instance);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(instance, context, results, true);
            errors.AddRange(results.Select(r => r.ErrorMessage));
            return isValid;
        }

        public static bool TryValidateFirstError(object instance, out string firstError)
        {
            firstError = null;
            if (instance == null) return false;

            var context = new ValidationContext(instance);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(instance, context, results, true);
            firstError = results.FirstOrDefault()?.ErrorMessage;
            return isValid;
        }
    }
}
