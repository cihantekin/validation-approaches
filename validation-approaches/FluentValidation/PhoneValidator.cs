using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace validation_approaches.FluentValidation
{
    internal partial class PhoneValidator : IPropertyValidator<AnotherPersonModel, string>
    {
        public string Name => throw new NotImplementedException();

        public string GetDefaultMessageTemplate(string errorCode)
        {
            return "This is not a valid phone number.";
        }

        public bool IsValid(ValidationContext<AnotherPersonModel> context, string value)
        {
            if (value != null) return PhoneCheck().IsMatch(value);
            else return false;
        }

        [GeneratedRegex("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        private static partial Regex PhoneCheck();
    }
}