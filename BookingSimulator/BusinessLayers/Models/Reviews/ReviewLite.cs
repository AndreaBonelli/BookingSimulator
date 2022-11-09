namespace BookingSimulator.BusinessLayers.Models.Reviews
{
    public class ReviewLite
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string? Content { get; set; }
        public int IdHotel { get; set; }
    }
}
