using BookingSimulator.BusinessLayers.Models;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface ICustomerService
    {
        public Customer Add(PostCustomerModel customer);
    }
}
