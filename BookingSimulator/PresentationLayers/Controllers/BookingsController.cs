using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.BusinessLayers.Services;
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

        [HttpPost]
        public IActionResult AddBooking([FromBody] PostBookingModel booking)
        {
            try
            {
                return Ok(_bookingService.Create(booking));
            }
            catch
            {
                return BadRequest("Customer or room not founded");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            try
            {
                _bookingService.Delete(id);
                return NoContent();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}