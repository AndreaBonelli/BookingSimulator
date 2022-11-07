using BookingSimulator.BusinessLayers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingSimulator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
    }
}