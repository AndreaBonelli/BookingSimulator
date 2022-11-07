using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasCustomer : IDasCustomer
    {
        private readonly BookingSimulatorContext _context;

        public Customer Add(Customer customer)
        {
            var customerToShow = _context.Customers.Add(customer);
            return customerToShow.Entity;
        }
    }
}
