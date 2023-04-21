using System.ComponentModel.DataAnnotations;

namespace login_register_Encryption_Hashing__Verification_11.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
