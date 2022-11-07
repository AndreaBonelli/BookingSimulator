using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Models.Rooms;
using BookingSimulator.Das.Context;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasCustomer
    {
        public Customer Add(Customer customer);
        public Customer GetById(int id);
    }
}
