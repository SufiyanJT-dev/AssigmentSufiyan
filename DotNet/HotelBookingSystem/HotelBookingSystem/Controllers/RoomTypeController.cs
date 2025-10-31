using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeServies _roomType;
        public RoomTypeController(IRoomTypeServies roomType)
        {
            this._roomType = roomType;

        }

        [HttpPost]
        public async Task<IActionResult> AddRoomType(AddRoomTypeDto addRoomTypeDto)
        {

            return Ok(await _roomType.AddRoomType(addRoomTypeDto));
        }
        [HttpGet]
        public async Task<IActionResult> GetALLRoomType()
        {
            return Ok(await _roomType.GetALLRoomType());
        }
        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetRoomTypeById(int roomId)
        {
            return Ok(await _roomType.GetRoomTypeById(roomId));
        }
        [HttpPatch("{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId,UpdateRoomTypeDto updateRoomTypeDto)
        {
            return Ok(await _roomType.UpdateRoom(roomId, updateRoomTypeDto));
            

        }
        [HttpDelete("{roomid}")]
        public async Task<IActionResult> DeleteRoomType(int roomid)
        {
            return Ok(await _roomType.DeleteRoomType(roomid));
        }
    }

}
