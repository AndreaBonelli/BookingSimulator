using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.BusinessLayers.Models.Rooms
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
