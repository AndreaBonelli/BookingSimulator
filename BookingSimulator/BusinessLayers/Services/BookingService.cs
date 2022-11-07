using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.BusinessLayers.Services
{
    public class BookingService : IBookingService
    {
        private readonly IDasBooking _dasBooking;
        private readonly IMapper _mapper;

        public BookingService(IDasBooking dasBooking, IMapper mapper)
        {
            _dasBooking = dasBooking;
            _mapper = mapper;
        }

        public Booking Create(PostBookingModel booking)
        {
            return _dasBooking.Add(_mapper.Map<Booking>(booking));
        }

        public void Delete(int id)
        {
            try
            {
                _dasBooking.Delete(id);
            }
            catch
            {
                throw new Exception($"Problems in deleting the booking with id={id}.\n" +
                                    $"The selected booking may not exist");
            }
            
        }
    }
}
