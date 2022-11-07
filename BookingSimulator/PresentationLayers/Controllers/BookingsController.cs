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
        public IActionResult AddBooking([FromBody] PostPutBookingModel booking)
        {
            try
            {
                var bookingToShow = _bookingService.Create(booking);
                
                return CreatedAtAction(nameof(GetDetails), new {Id = bookingToShow.Id }, bookingToShow);
            }
            catch(ArgumentNullException ex)
            {
                return BadRequest("Customer or room not founded");
            }
            catch (InvalidOperationException ex2)
            {
                return BadRequest("Customer or room not founded");
            }
            catch (ArgumentException ex3)
            {
                return BadRequest("Room not available");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {
            try
            {
                var updatedBooking = _bookingService.GetById(id);
                return Ok(updatedBooking);
            }
            catch(Exception e)
            {
                return NotFound();
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
            catch(Exception ex)
            {
                return BadRequest($"Problems in deleting the booking with id = {id}.\n" +
                                    $"The selected booking may not exist");
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, [FromBody] PostPutBookingModel booking)
        {
            try
            {
                var updatedBooking = _bookingService.Update(id, booking);
                
                return Ok(updatedBooking);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest("Customer or room not founded");
            }
            catch (InvalidOperationException ex2)
            {
                return BadRequest("Customer or room not founded");
            }
            catch (ArgumentException ex3)
            {
                return BadRequest("Room not available");
            }
            
        }

    }
}