using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace validation_approaches.FluentValidation
{
    internal partial class PhoneValidator : IPropertyValidator<AnotherPersonModel, string>
    {
        public string Name => "Phone";

        public string GetDefaultMessageTemplate(string errorCode)
        {
            return "This is not a valid phone number.";
        }

        public bool IsValid(ValidationContext<AnotherPersonModel> context, string value)
        {
            if (value != null) return PhoneCheck().IsMatch(value);
            else return false;
        }

        [GeneratedRegex("^\\+?[1-9][0-9]{7,14}$")]
        private static partial Regex PhoneCheck();
    }
}