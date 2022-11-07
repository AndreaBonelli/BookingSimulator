using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Customers;

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
