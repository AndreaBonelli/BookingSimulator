using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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

        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] PostCustomerModel customerToInsert)
        //{
        //    ValidationResult results =  await _validator.ValidateAsync(customerToInsert);

        //    if (!results.IsValid)
        //        return BadRequest(results.ToString("\n"));

        //    var customerToShow = _customerService.Add(customerToInsert);
        //    return Ok(customerToShow);

        //    //if (!results.IsValid)
        //    //{
        //    //    var errors = String.Empty;
        //    //    foreach (var failure in results.Errors)
        //    //    {
        //    //        errors += $"Property {failure.PropertyName} failed validation. Error was: {failure.ErrorMessage}\n";
        //    //    }
        //    //    return BadRequest(errors);
        //    //}

        //}

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PostCustomerModel customerToInsert)
        {
            try
            {
                await _validator.ValidateAndThrowAsync(customerToInsert);
                var customerToShow = _customerService.Add(customerToInsert);
                return Ok(customerToShow);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
