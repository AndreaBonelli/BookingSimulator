using AutoMapper;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.BusinessLayers.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IDasCustomer _dasCustomer;
        private readonly IMapper _mapper;

        public CustomerService(IDasCustomer dasCustomer, IMapper mapper)
        {
            _dasCustomer = dasCustomer;
            _mapper = mapper;
        }
    }
}
