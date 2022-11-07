using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Models.Rooms;

namespace BookingSimulator.BusinessLayers.Models.Bookings
{
    public class PostBookingModel
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}