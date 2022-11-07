using BookingSimulator.BusinessLayers.Models;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingSimulator.PresentationLayers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] PostCustomerModel customerToInsert)
        {
            var customerToShow = _customerService.Add(customerToInsert);
            return Ok(customerToShow);
        }
    }
}
