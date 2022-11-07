using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasHotel
    {
        public Hotel Add(Hotel hotel);
        public Hotel Update(int id, Hotel hotel);
    }
}
