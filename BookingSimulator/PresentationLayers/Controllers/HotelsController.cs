using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingSimulator.PresentationLayers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost]
        public IActionResult AddHotel([FromBody] PostHotelModel hotel)
        {
            return Ok(_hotelService.Create(hotel));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] PutHotelModel hotel)
        {
            return Ok(_hotelService.Update(id, hotel));
        }
    }
}
