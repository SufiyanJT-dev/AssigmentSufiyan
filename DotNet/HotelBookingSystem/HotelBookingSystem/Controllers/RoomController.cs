using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomSerices roomSerices;

        public RoomController(IRoomSerices roomSerices)
        {
            this.roomSerices = roomSerices;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var GetRoom = await roomSerices.GetAllRooms();
            return Ok(GetRoom);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddUpdateRoomDto addUpdateRoomDto)
        {
            var AddRoom = await roomSerices.AddRooms(addUpdateRoomDto);
            return Ok( AddRoom);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var GetByID = await roomSerices.GetRoomsById(id);
            return Ok(GetByID);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AddUpdateRoomDto addUpdateRoomDto)
        {
            var UpdateID = await roomSerices.UpdateRooms(id, addUpdateRoomDto);


            return Ok(UpdateID);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await roomSerices.DeleteRooms(id));


        }

    }
}
