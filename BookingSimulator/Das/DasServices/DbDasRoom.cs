using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Rooms;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasRoom : IDasRoom
    {
        private readonly BookingSimulatorContext _context;

        public DbDasRoom(BookingSimulatorContext context)
        {
            _context = context;
        }

        public Room GetById(int id)
        {
            return _context.Rooms.Single(b => b.Id == id);
        }
    }
}
