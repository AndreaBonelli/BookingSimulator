using AutoMapper;
using BookingSimulator.BusinessLayers.Models;
using BookingSimulator.BusinessLayers.Models.PostModels;

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
