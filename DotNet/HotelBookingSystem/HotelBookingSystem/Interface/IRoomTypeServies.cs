

using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;
namespace HotelBookingSystem.Interface
{
    public interface IRoomTypeServies
    {
        public Task<List<RoomType>> GetALLRoomType();
        public Task<RoomType> GetRoomTypeById(int roomId);
        public Task<string> DeleteRoomType(int roomId);
        public Task<bool> UpdateRoom(int roomId, UpdateRoomTypeDto updateRoomTypeDto);
        public Task<RoomType> AddRoomType(AddRoomTypeDto addRoomTypeDto);

    }
}