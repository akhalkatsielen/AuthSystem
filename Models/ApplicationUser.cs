using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        // = "" -> დეფოლტად ცარიელი სტრინგის მისანიჭებლად
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
