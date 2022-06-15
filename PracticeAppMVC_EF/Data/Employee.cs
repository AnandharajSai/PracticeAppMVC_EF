using Microsoft.AspNetCore.Identity;

namespace PracticeAppMVC_EF.Data
{
    public class Employee : IdentityUser
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }
    }
}
