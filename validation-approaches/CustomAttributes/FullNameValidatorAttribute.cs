using System.ComponentModel.DataAnnotations;

namespace validation_approaches.CustomAttributes
{
    public class FullNameValidatorAttribute : ValidationAttribute
    {
        private const int MaxFullnameCharacter = 65;

        public override bool IsValid(object? value)
        {
            string fullName = value?.ToString() ?? "";

            if (string.IsNullOrEmpty(fullName))
                return false;
            

            if (fullName.Length > MaxFullnameCharacter)
            {
                ErrorMessage = $"Max character for a fullname is {MaxFullnameCharacter}";
                return false;
            }

            if (fullName.ToCharArray().Any(char.IsDigit))
            {
                ErrorMessage = "Fullname cannot contain a digital character";
                return false;
            }

            return true;
        }
    }
}
