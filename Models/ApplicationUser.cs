using Microsoft.AspNetCore.Identity;

namespace EE_Commerce.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
    }
}
