using Microsoft.EntityFrameworkCore;

namespace WebApplication2.model
{
    public class HotellistingDbContext: DbContext
    {
        public HotellistingDbContext(DbContextOptions opctions): base(opctions)
        {

        
        }
        public DbSet<Hotel>Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                     Id= 1,
                    Name = "India",
                    ShortName = "in",

                },
                new Country
                {
                    Id = 2,
                    Name = "Pakistan",
                    ShortName = "Pk",

                },
                new Country
                {
                    Id = 3,
                    Name = "Chaina",
                    ShortName = "Ch",

                }

                );
            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "taj hotel",
                    Address = "Delhi",
                    CountryId = 1,
                    rating = 5,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "srinivas",
                    Address = "ponnur",
                    CountryId = 1,
                    rating = 4.3,

                },
                new Hotel
                {
                    Id = 3,
                    Name = "chavu ming ",
                    Address = "unkonwn",
                    CountryId = 3,
                    rating = 5,
                }
                ) ;
        }
    }
}
