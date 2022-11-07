using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasBooking : IDasBooking
    {
        private readonly BookingSimulatorContext _context;

        public DbDasBooking(BookingSimulatorContext context)
        {
            _context = context;
        }

        public Booking Add(Booking booking)
        {
            var customerToFind = _context.Customers.Single(c => c.Id == booking.CustomerId);
            var roomToFind = _context.Rooms.Single(r => r.Id == booking.RoomId);

            var added = _context.Bookings.Add(booking);
            _context.SaveChanges();
            return added.Entity;              
        }
    }
}
