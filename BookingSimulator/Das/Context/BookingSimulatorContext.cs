using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.BusinessLayers.Models.Reviews;
using BookingSimulator.BusinessLayers.Models.Rooms;
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
