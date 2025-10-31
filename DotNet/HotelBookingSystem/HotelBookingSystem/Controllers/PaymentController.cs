using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly  IPaymentServices paymentServices;

        public PaymentController(IPaymentServices paymentServices)
        {
            this.paymentServices = paymentServices;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var GetRoom = await paymentServices.GetAll();
            return Ok(GetRoom);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddUpdatePaymentDto addUpdatePaymentDto)
        {
            var Add = await paymentServices.Add(addUpdatePaymentDto);
            return Ok(Add);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var GetByID = await paymentServices.GetById(id);
            return Ok(GetByID);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AddUpdatePaymentDto addUpdatePaymentDto)
        {
            var UpdateID = await paymentServices.Update(id, addUpdatePaymentDto);


            return Ok(UpdateID);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await paymentServices.Delete(id));


        }
    }
}
