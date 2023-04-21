using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace login_register_Encryption_Hashing__Verification_11.Models
{
    public class State
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
