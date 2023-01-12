
namespace validation_approaches.FluentValidation
{
    [PersonValidator]
    public class AnotherPersonModel
    {
        public string FullName { get; set; } = new("");
        public string Email { get; set; } = new("");
        public string Address { get; set; } = new("");
        public string Phone { get; set; } = new("");
        public int Age { get; set; }    
    }
}
