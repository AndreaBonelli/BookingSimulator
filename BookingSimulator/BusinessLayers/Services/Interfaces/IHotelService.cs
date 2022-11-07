using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IHotelService
    {
        public Hotel Create(PostHotelModel postHotelModel);
    }
}
