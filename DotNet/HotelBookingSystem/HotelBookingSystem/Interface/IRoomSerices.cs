using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
    public interface IRoomSerices
    {
        public Task<IEnumerable<Rooms>> GetAllRooms();
        public Task<Rooms> GetRoomsById(int roomId);
        public Task<string> DeleteRooms(int roomId);
        public Task<bool> UpdateRooms(int roomId, AddUpdateRoomDto addUpdateRoomDto);
        public Task<Rooms> AddRooms(AddUpdateRoomDto addUpdateRoomDto);
    }
}
