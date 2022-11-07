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

        public Hotel Update(int id, Hotel hotel)
        {
            try
            {
                var hotelToModify = _context.Hotels.Single(h => h.Id == id);
                hotelToModify.Name = hotel.Name;
                var updated = _context.Hotels.Update(hotelToModify);
                _context.SaveChanges();
                return updated.Entity;
            }
            catch
            {
                hotel.Id = 0;
                var added = _context.Hotels.Add(hotel);
                _context.SaveChanges();
                return added.Entity;
            }

        }
    }
}
