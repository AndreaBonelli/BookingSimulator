using BookingSimulator.BusinessLayers.Models;
using BookingSimulator.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace BookingSimulator.Das.Context
{
    public class BookingSimulatorContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public BookingSimulatorContext(DbContextOptions<BookingSimulatorContext> options)
           : base(options)
        {

        }
    }
}
