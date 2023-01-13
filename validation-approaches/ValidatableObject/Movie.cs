using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace validation_approaches.ValidatableObject
{
    public class Movie : IValidatableObject
    {
        [Required]
        [MaxLength(120)]
        [MinLength(1)]
        public string Title { get; set; } = new("");

        public string Director { get; set; } = new("");

        [Required]
        [StringLength(500)]
        public string MovieDetail { get; set; } = new("");

        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Genre == Genre.Classic && ReleaseDate.Year > 1960)
            {
                yield return new ValidationResult($"Classic movies release that should not be later than 1960", new[] { nameof(ReleaseDate) });
            }
        }
    }

    public enum Genre
    {
        Classic,
        Drama,
        Fantastic,
        Action,
        Comedy
    }
}
