using BookingSimulator.BusinessLayers.Models.Hotels;
using Microsoft.AspNetCore.Mvc;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IHotelService
    {
        public Hotel Create(PostHotelModel postHotelModel);
        public IEnumerable<Hotel> GetAll();
        public Hotel Update(int id, PutHotelModel putHotelModel);
    }
}
