using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            this.employeeServices = employeeServices;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var GetRoom = await employeeServices.GetAll();
            return Ok(GetRoom);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddUpdateEmployeeDto addUpdateEmployeeDto)
        {
            var Add = await employeeServices.Add(addUpdateEmployeeDto);
            return Ok(Add);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var GetByID = await employeeServices.GetById(id);
            return Ok(GetByID);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AddUpdateEmployeeDto addUpdateEmployeeDto)
        {
            var UpdateID = await employeeServices.Update(id, addUpdateEmployeeDto);


            return Ok(UpdateID);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await employeeServices.Delete(id));


        }
    }
}
