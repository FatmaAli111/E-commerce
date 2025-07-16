using Microsoft.AspNetCore.Identity;

namespace EEcomercEE.Models.entities
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
    }
}
