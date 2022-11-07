using AutoMapper;
using BookingSimulator.BusinessLayers.Models.PostModels;
using BookingSimulator.Models;

namespace BookingSimulator.BusinessLayers.Profiles
{
    public class HotelMapperProfile : Profile
    {
        public HotelMapperProfile()
        {
            CreateMap<PostHotelModel, Hotel>();
        }
    }
}
