using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        // Insert Data on Database creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg",
                    Occupancy = 4,
                    Rate = 50,
                    Sqft = 550,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg",
                    Occupancy = 4,
                    Rate = 50,
                    Sqft = 550,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 3,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg",
                    Occupancy = 4,
                    Rate = 50,
                    Sqft = 550,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 4,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg",
                    Occupancy = 4,
                    Rate = 50,
                    Sqft = 550,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 5,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg",
                    Occupancy = 4,
                    Rate = 50,
                    Sqft = 550,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
