using BookingSimulator.BusinessLayers.Models.Customers;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface ICustomerService
    {
        public Customer Add(PostCustomerModel customer);
    }
}
