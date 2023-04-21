using System.ComponentModel.DataAnnotations;

namespace login_register_Encryption_Hashing__Verification_11.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
