using BookingSimulator.BusinessLayers.Models.PostModels;
using BookingSimulator.Models;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IHotelService
    {
        public Hotel Create(PostHotelModel postHotelModel);
    }
}
