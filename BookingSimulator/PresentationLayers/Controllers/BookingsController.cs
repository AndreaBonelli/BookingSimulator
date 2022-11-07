using BookingSimulator.BusinessLayers.Models.Bookings;
using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.BusinessLayers.Services;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

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
                return BadRequest($"Problems in deleting the booking with id={id}.\n" +
                                    $"The selected booking may not exist");
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, [FromBody] PostBookingModel pbm)
        {
            var updatedBooking = _bookingService.Update(id, pbm);
            return Ok(updatedBooking);
        }

    }
}