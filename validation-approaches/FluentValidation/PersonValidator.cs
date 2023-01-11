using FluentValidation;
using validation_approaches.ModelBindingValidation;

namespace validation_approaches.FluentValidation
{
    public class PersonValidator : AbstractValidator<AnotherPersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FullName).NotNull();
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.FullName).MaximumLength(65);
            RuleFor(p => p.FullName).MinimumLength(2);

            RuleFor(p => p.Email).NotEmpty().NotNull().EmailAddress();
            
            RuleFor(p => p.Address).NotEmpty().NotNull().MaximumLength(100);

            RuleFor(p => p.Phone).NotEmpty().NotNull().SetValidator(new PhoneValidator());

            RuleFor(p => p.Age).InclusiveBetween(0, 120);
        }
    }
}
