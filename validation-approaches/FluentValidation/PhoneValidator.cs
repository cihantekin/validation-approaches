using FluentValidation;
using FluentValidation.Validators;
using validation_approaches.ModelBindingValidation;

namespace validation_approaches.FluentValidation
{
    internal class PhoneValidator : IPropertyValidator<Person, string>
    {
        public string Name => throw new NotImplementedException();

        public string GetDefaultMessageTemplate(string errorCode)
        {
            return "This is not a valid phone number.";
        }

        public bool IsValid(ValidationContext<Person> context, string value)
        {
            throw new NotImplementedException();
        }
    }
}