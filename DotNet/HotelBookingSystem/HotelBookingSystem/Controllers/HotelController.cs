using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServices _hotelServices;
        public HotelController(IHotelServices hotelServices)
        {
            _hotelServices = hotelServices;
        }
        [HttpGet]
        public async Task<IActionResult> SelectAllHotel() {

            var hotels = await _hotelServices.SelectAllHotel();
            return Ok(hotels);
        }

        [HttpPost]

        public async Task<IActionResult> AddAddHotel(AddHotelDto addHotelDto)
        {
            var Addhotel = await _hotelServices.AddHotel(addHotelDto);
            return Ok(Addhotel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SelectById(int id)
        {
             var hoteldetails=await _hotelServices.SelectById(id);
            if (hoteldetails == null)
                return NotFound($"Hotel with ID {id} not found.");
            return Ok(hoteldetails);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHotel(int id,[FromBody]AddHotelDto addHotelDto)
        {
            return Ok(await _hotelServices.UpdateHotel(id, addHotelDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var Hotelupdate =await  _hotelServices.DeleteHotel(id);

            return Ok(Hotelupdate);
        }

    }
}
