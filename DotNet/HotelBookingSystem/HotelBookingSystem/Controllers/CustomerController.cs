using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBookingSystem.DataB;

using Microsoft.EntityFrameworkCore;
using HotelBookingSystem.models;
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Services;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        
        public CustomerController(ICustomerService customerService)
        {
           this._customerService = customerService;
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerdto addCustomerdto )
        {
            var Customer = await _customerService.AddAsycCustomer(addCustomerdto);
            return Ok(Customer);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var AllCustomer = await _customerService.GetAllCustomer();
            return Ok(AllCustomer);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDCustomer(int id)
        {
            var GetByIDCustomer = await _customerService.GetCustomerById(id);
            return Ok(GetByIDCustomer);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, UpdateCustomerDto updateCustomerDto)
        {
            var UpdateCustomerbyID=await _customerService.UpdateCustomerById(id,updateCustomerDto);


            return Ok(UpdateCustomerbyID);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return Ok(  await _customerService.DeleteCustomer(id));
      
          
        }
       
    }
}
