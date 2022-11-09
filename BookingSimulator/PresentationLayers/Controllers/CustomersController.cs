using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingSimulator.PresentationLayers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IValidator<PostCustomerModel> _validator;
        public CustomersController(ICustomerService customerService, IValidator<PostCustomerModel> validator)
        {
            _customerService = customerService;
            _validator = validator; 
        }

        [HttpPost]
        public IActionResult Add([FromBody] PostCustomerModel customerToInsert)
        {
            var validationResults = _validator.Validate(customerToInsert);

            if(!validationResults.IsValid)
                return BadRequest(validationResults.ToString());

            var customerToShow = _customerService.Add(customerToInsert);
            return Ok(customerToShow);
        }


        //[HttpPost]
        //public async Task<IActionResult> Add2([FromBody] PostCustomerModel customerToInsert)
        //{
        //    try
        //    {
        //        await _validator.ValidateAndThrowAsync(customerToInsert);
        //        var customerToShow = _customerService.Add(customerToInsert);
        //        return Ok(customerToShow);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
