using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.DataB
{
    public class HotelBookingSystemContex : DbContext
    {

        public DbSet<models.Booking> Bookings { get; set; }
        public DbSet<models.Customer> Customers { get; set; }
        public DbSet<models.Employee> Employees { get; set; }
        public DbSet<models.Hotel> Hotels { get; set; }

        public DbSet<models.Payment> Payments { get; set; }
        public DbSet<models.Review> Review { get; set; }
        public DbSet<models.Rooms> Room { get; set; }
        public DbSet<models.RoomType> RoomTypes { get; set; }
        public HotelBookingSystemContex(DbContextOptions options) : base(options)
        {
        }
        
        protected HotelBookingSystemContex()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<models.Booking>().Property(r=>r.TotalAmount).HasPrecision(10,2);
            modelBuilder.Entity<models.Payment>().Property(r => r.Amount).HasPrecision(10, 2);
            modelBuilder.Entity<models.Rooms>().Property(r => r.PricePerNight).HasPrecision(10, 2);
        }

        
    }
}
