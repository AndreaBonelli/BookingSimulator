using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasHotel
    {
        public Hotel Add(Hotel hotel);
        public IEnumerable<Hotel> GetAll();
        public Hotel Update(int id, Hotel hotel);
    }
}
