using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasHotel : IDasHotel
    {
        public readonly BookingSimulatorContext _context;

        public DbDasHotel (BookingSimulatorContext context)
        {
            _context = context;
        }
        public Hotel Add(Hotel hotel)
        {
            var added = _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return added.Entity;
        }

        public Hotel GetById(int id)
        {
            return _context.Hotels.Single(h => h.Id == id);
        }

        public Hotel Update(Hotel hotel)
        {
            var updatedHotel = _context.Hotels.Update(hotel);
            _context.SaveChanges();
            return updatedHotel.Entity;

        }
    }
}
