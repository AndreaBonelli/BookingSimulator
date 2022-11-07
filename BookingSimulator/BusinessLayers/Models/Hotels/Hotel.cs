using BookingSimulator.BusinessLayers.Models.Reviews;
using BookingSimulator.BusinessLayers.Models.Rooms;

namespace BookingSimulator.BusinessLayers.Models.Hotels
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}

