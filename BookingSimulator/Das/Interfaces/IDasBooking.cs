using BookingSimulator.BusinessLayers.Models.Bookings;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasBooking
    {
        public Booking Add(Booking booking);
        public void Delete(int id);
        public Booking Update(Booking booking);
        public IEnumerable<Booking> GetAll();
        public Booking GetById(int id);
    }
}
