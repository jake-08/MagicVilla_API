using MagicVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        // Insert Data on Database creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/03/28/09/34/bedroom-1285156__340.jpg",
                    Occupancy = 2,
                    Rate = 150,
                    Sqft = 800,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/04/28/22/16/room-2269594__340.jpg",
                    Occupancy = 4,
                    Rate = 250,
                    Sqft = 1000,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2020/10/18/09/16/bedroom-5664221__340.jpg",
                    Occupancy = 2,
                    Rate = 150,
                    Sqft = 650,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/04/15/11/46/bedroom-1330846__340.jpg",
                    Occupancy = 4,
                    Rate = 350,
                    Sqft = 900,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    ImageUrl = "https://cdn.pixabay.com/photo/2019/08/19/13/58/bed-4416515__340.jpg",
                    Occupancy = 2,
                    Rate = 250,
                    Sqft = 800,
                    Amenity = "Free Drinks",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
