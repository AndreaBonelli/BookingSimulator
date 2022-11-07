using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.BusinessLayers.Models.Reviews
{
    public class Review
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string? Content { get; set; }
        public int IdHotel { get; set; }
        public Hotel Hotel { get; set; }
    }
}
