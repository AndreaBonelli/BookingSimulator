using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Bookings;

namespace BookingSimulator.BusinessLayers.Profiles
{
    public class BookingMapperProfile : Profile
    {
        public BookingMapperProfile()
        {
            CreateMap<PostPutBookingModel, Booking>();
        }
    }
}
