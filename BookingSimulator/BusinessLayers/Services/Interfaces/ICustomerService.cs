using BookingSimulator.BusinessLayers.Models;
using BookingSimulator.BusinessLayers.Models.PostModels;

namespace BookingSimulator.BusinessLayers.Services.Interfaces
{
    public interface ICustomerService
    {
        public Customer Add(PostCustomerModel customer);
    }
}
