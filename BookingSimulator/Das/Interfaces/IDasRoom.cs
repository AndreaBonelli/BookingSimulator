using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Rooms;
using Microsoft.EntityFrameworkCore;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasRoom
    {
        public Room GetById(int id);
    }
}
