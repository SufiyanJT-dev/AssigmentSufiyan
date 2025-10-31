using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

       
            private readonly IBookingSerivce bookingSerivce;

            public BookingController(IBookingSerivce bookingSerivce)
            {
                this.bookingSerivce = bookingSerivce;
            }
            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var GetRoom = await bookingSerivce.GetAll();
                return Ok(GetRoom);
            }
            [HttpPost]
            public async Task<IActionResult> Add(AddUpdateBookingDto addUpdateBookingDto)
            {
                var Add = await bookingSerivce.Add(addUpdateBookingDto);
                return Ok(Add);

            }
            [HttpGet("{id}")]
            public async Task<IActionResult> GetByID(int id)
            {
                var GetByID = await bookingSerivce.GetById(id);
                return Ok(GetByID);

            }
            [HttpPut("{id}")]
            public async Task<IActionResult> Update(int id, AddUpdateBookingDto addUpdateBookingDto)
            {
                var UpdateID = await bookingSerivce.Update(id, addUpdateBookingDto);


                return Ok(UpdateID);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                return Ok(await bookingSerivce.Delete(id));


            }
        }
    }


