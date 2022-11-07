using BookingSimulator.BusinessLayers.Models.Bookings;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface IBookingService
    {
        public Booking Create(PostPutBookingModel booking);
        public void Delete(int id);
        public Booking GetById(int id);
        public Booking Update(int id, PostPutBookingModel booking);
    }
}
