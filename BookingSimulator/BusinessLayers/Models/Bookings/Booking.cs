using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Models.Rooms;

namespace BookingSimulator.BusinessLayers.Models.Bookings
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
