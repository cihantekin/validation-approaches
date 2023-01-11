using FluentValidation;
using FluentValidation.Validators;

namespace validation_approaches.FluentValidation
{
    internal class PhoneValidator : IPropertyValidator<AnotherPersonModel, string>
    {
        public string Name => throw new NotImplementedException();

        public string GetDefaultMessageTemplate(string errorCode)
        {
            return "This is not a valid phone number.";
        }

        public bool IsValid(ValidationContext<AnotherPersonModel> context, string value)
        {
            throw new NotImplementedException();
        }
    }
}