using login_register_Encryption_Hashing__Verification_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace login_register_Encryption_Hashing__Verification_11.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}




