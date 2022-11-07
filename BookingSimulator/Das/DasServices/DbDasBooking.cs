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
        public Booking GetById(int id)
        {
            return _context.Bookings.Single(b => b.Id == id);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings;
        }
        public Booking Add(Booking booking)
        {
            var added = _context.Bookings.Add(booking);
            _context.SaveChanges();
            return added.Entity;              
        }

        public void Delete(int id)
        {
            var toDelete = _context.Bookings.Single(b => b.Id == id);
            _context.Remove(toDelete);
            _context.SaveChanges();
        }

        public Booking Update(Booking booking)
        {
            var added = _context.Bookings.Update(booking);
            _context.SaveChanges();
            return added.Entity;
        }
    }
}
