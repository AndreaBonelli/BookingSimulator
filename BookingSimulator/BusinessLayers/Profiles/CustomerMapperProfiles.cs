using AutoMapper;
using BookingSimulator.BusinessLayers.Models;

namespace BookingSimulator.BusinessLayers.Profiles
{
    public class CustomerMapperProfiles : Profile
    {
        public CustomerMapperProfiles()
        {
            CreateMap<PostCustomerModel, Customer>();
        }
    }
}
