using System.ComponentModel.DataAnnotations;
using validation_approaches.ModelBindingValidation;

namespace validation_approaches.FluentValidation
{
    public class PersonValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is null)
                return false;

            var validator = new PersonValidator();
            var result = validator.Validate((AnotherPersonModel)value);
            ErrorMessage = result.ToString();
            return result.IsValid;
        }
    }
}
