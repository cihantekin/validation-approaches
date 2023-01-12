using System.ComponentModel.DataAnnotations;
using validation_approaches.CustomAttributes;

namespace validation_approaches.ModelBindingValidation
{
    public class Person
    {
        [Required]
        [FullNameValidator]
        public string FullName { get; set; } = new ("");

        [EmailAddress]
        public string Email { get; set; } = new("");

        [MaxLength(100)]
        public string Address { get; set; } = new("");

        [Phone]
        public string Phone { get; set; } = new("");

        [Range(0, 120)]
        public int Age { get; set; }
    }
}
