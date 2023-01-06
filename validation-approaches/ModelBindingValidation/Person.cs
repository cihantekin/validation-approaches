using System.ComponentModel.DataAnnotations;

namespace validation_approaches.ModelBindingValidation
{
    public class Person
    {
        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }


    }
}
