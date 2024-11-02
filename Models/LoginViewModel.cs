using System.ComponentModel.DataAnnotations;

namespace EE_Commerce.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required"),MaxLength(10),MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name ="Remember Me")]
        public bool rememberme {  get; set; }
       
    }
}
