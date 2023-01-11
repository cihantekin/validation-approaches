
namespace validation_approaches.FluentValidation
{
    [PersonValidator]
    public class AnotherPersonModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}
