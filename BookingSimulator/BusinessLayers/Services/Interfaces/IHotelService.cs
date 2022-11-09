using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IHotelService
    {
        public Hotel Create(PostPutHotelModel postHotelModel);
        public Hotel Update(int id, PostPutHotelModel putHotelModel);
    }
}
