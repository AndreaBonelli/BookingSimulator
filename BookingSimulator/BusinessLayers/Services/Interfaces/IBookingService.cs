using BookingSimulator.BusinessLayers.Models.Bookings;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IBookingService
    {
        public Booking Create(PostBookingModel booking);
    }
}
