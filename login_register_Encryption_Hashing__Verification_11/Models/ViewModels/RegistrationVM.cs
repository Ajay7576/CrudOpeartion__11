using System.ComponentModel.DataAnnotations;

namespace login_register_Encryption_Hashing__Verification_11.Models.ViewModels
{
    public class RegistrationVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }

    }
}
