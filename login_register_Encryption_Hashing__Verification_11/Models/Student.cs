using System.ComponentModel.DataAnnotations.Schema;

namespace login_register_Encryption_Hashing__Verification_11.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public int  Age { get; set; }
        public string Address { get; set; }
        public int ContectNo { get; set; }
        public byte[] Picture { get; set; }
        public enum  gender { Male,Female }
        public gender  Gender { get; set; }
        public bool Subscribe { get; set; }
        public DateTime CreatedOn { get; set; }


        [NotMapped]
        public int CountryId { get; set; }
        [NotMapped]
        public int StateId { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }





    }
}
