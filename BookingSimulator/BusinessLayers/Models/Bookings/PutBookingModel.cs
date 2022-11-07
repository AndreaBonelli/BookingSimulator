namespace BookingSimulator.BusinessLayers.Models.Bookings
{
    public class PutBookingModel
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
