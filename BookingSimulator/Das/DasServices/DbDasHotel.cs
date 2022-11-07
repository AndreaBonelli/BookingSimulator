using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasHotel : IDasHotel
    {
        public readonly BookingSimulatorContext _ctx;

        public DbDasHotel (BookingSimulatorContext ctx)
        {
            _ctx = ctx;
        }
        public Hotel Add(Hotel hotel)
        {
            var added = _ctx.Hotels.Add(hotel);
            _ctx.SaveChanges();
            return added.Entity;
        }
    }
}
