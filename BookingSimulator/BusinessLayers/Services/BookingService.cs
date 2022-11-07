using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Rooms;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookingSimulator.BusinessLayers.Services
{
    public class BookingService : IBookingService
    {
        private readonly IDasBooking _dasBooking;
        private readonly IDasCustomer _dasCustomer;
        private readonly IDasRoom _dasRoom;
        private readonly IMapper _mapper;

        public BookingService(IDasBooking dasBooking, IDasCustomer dasCustomer, IDasRoom dasRoom, IMapper mapper)
        {
            _dasBooking = dasBooking;
            _dasCustomer = dasCustomer;
            _dasRoom = dasRoom;
            _mapper = mapper;
        }

        public Booking Create(PostBookingModel booking)
        {
            var customerToFind = _dasCustomer.GetById(booking.CustomerId);
            var roomToFind = _dasRoom.GetById(booking.RoomId);

            if (IsRoomAvailable(booking))
            {
                return _dasBooking.Add(_mapper.Map<Booking>(booking));
            }

            throw new ArgumentException();
            
        }

        public void Delete(int id)
        {
            _dasBooking.Delete(id);
            
        }

        public Booking Update(int id, PostBookingModel pbm)
        {
            var booking = _mapper.Map<Booking>(pbm);
            booking.Id = id;
            return _dasBooking.Update(booking);
        }

        private bool IsRoomAvailable(PostBookingModel booking)
        {
            return !_dasBooking.GetAll().Where(b => b.RoomId == booking.RoomId).
                Any(b => b.EndDate > booking.StartDate && b.StartDate < booking.EndDate);
        }
    }
}
