using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyHotel.Models;

namespace MyHotel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }


    }
}
