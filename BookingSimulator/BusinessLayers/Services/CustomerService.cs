using AutoMapper;
using BookingSimulator.BusinessLayers.Models;
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

        public Customer Add(PostCustomerModel customerToInsert)
        {
            var customer = _mapper.Map<Customer>(customerToInsert);
            var customerToShow = _dasCustomer.Add(customer);
            return customerToShow;
        }
    }
}
