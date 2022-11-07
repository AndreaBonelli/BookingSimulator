using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.Das.DasServices
{
    public class DbDasCustomer : IDasCustomer
    {
        private readonly BookingSimulatorContext _context;

        public DbDasCustomer(BookingSimulatorContext context)
        {
            _context = context;
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Single(b => b.Id == id);
        }
        public Customer Add(Customer customer)
        {
            var customerToShow = _context.Customers.Add(customer);
            _context.SaveChanges();
            return customerToShow.Entity;
        }

    }
}
