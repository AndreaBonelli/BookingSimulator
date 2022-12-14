using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Hotels;

namespace BookingSimulator.BusinessLayers.Profiles
{
    public class HotelMapperProfile : Profile
    {
        public HotelMapperProfile()
        {
            CreateMap<PostHotelModel, Hotel>();
            CreateMap<PutHotelModel, Hotel>();
        }
    }
}
