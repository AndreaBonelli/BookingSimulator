using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Rooms;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;

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

        public Booking Create(PostPutBookingModel booking)
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

        public Booking GetById(int id)
        {
            return _dasBooking.GetById(id);
        }

        public Booking Update(int id, PostPutBookingModel booking)
        {
            var customerToFind = _dasCustomer.GetById(booking.CustomerId);
            var roomToFind = _dasRoom.GetById(booking.RoomId);

            if (IsRoomAvailable(booking))
            {
                var bookingToUpdate = _mapper.Map<Booking>(booking);
                try
                {
                    bookingToUpdate.Id = id;
                    return _dasBooking.Update(bookingToUpdate);
                }
                catch(Exception ex)
                {
                    bookingToUpdate.Id = 0;
                    return _dasBooking.Add(bookingToUpdate);
                }
                
            }

            throw new ArgumentException();
        }

        private bool IsRoomAvailable(PostPutBookingModel booking)
        {
            return ! _dasBooking.GetAll().Where(b => b.RoomId == booking.RoomId).
                Any(b => b.EndDate > booking.StartDate && b.StartDate < booking.EndDate);
        }

    }
}
