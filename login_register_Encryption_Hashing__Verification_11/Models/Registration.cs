using System.ComponentModel.DataAnnotations;

namespace login_register_Encryption_Hashing__Verification_11.Models
{
    public class Registration
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        
        public string? OTP { get; set; }

        public DateTime MailSendTime { get; set; }

        public bool IsEmailVerified { get; set; }

        public DateTime OtpSendTime { get; set; }

    }
}
