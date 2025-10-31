using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class RoomSerices : IRoomSerices
    {
        private readonly HotelBookingSystemContex context;

        public RoomSerices(HotelBookingSystemContex context)
        {
            this.context = context;
        }

       
       

        public async Task<string> DeleteRooms(int roomId)
        {
            var DeleteRoomId=await context.Room.FirstOrDefaultAsync(R=>R.Id==roomId);
            if (DeleteRoomId == null)
            {
                return "failed";
            }
            context.Room.Remove(DeleteRoomId);
            context.SaveChanges();
            return "Succesfully deleted";
        }

         public async Task<IEnumerable<Rooms>> GetAllRooms()
        {
            var roomsList= await context.Room.ToListAsync();
            return  roomsList;
        }

        public async Task<Rooms> GetRoomsById(int roomId)
        {
            var roomsList = await context.Room.FirstOrDefaultAsync(r=>r.Id==roomId);

            return roomsList;
        }



         public async  Task<bool> UpdateRooms(int roomId, AddUpdateRoomDto addUpdateRoomDto)
        {
           
           var RoomUpdateId=await context.Room.FirstOrDefaultAsync(r=>r.Id==roomId);
            if (RoomUpdateId == null)
            {
                return false;
            }
            RoomUpdateId.RoomNumber=addUpdateRoomDto.RoomNumber;
            RoomUpdateId.Status=addUpdateRoomDto.Status;
            RoomUpdateId.HotelId=addUpdateRoomDto.HotelId;
            RoomUpdateId.PricePerNight=addUpdateRoomDto.PricePerNight;
            RoomUpdateId.RoomTypeId=addUpdateRoomDto.RoomTypeId;
           await  context.SaveChangesAsync();
            return true;
        }

        public async Task<Rooms> AddRooms(AddUpdateRoomDto addUpdateRoomDto)
        {
          Rooms rooms = new Rooms();
            rooms.RoomNumber=addUpdateRoomDto.RoomNumber;
            rooms.Status=addUpdateRoomDto.Status;
            rooms.HotelId=addUpdateRoomDto.HotelId;
            rooms.RoomTypeId=addUpdateRoomDto.RoomTypeId;
            rooms.PricePerNight=addUpdateRoomDto.PricePerNight;
            context.Room.Add(rooms);
            await context.SaveChangesAsync();
            return rooms;
        }
    }
}
