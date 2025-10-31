using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class RoomTypeServices:IRoomTypeServies
    {
        private readonly HotelBookingSystemContex _DbContext; 
        public RoomTypeServices(HotelBookingSystemContex Dbcontext)
        {
            _DbContext = Dbcontext;
            
        }

        public async Task<RoomType> AddRoomType( AddRoomTypeDto addRoomTypeDto)
        {

            RoomType roomType = new RoomType();
            roomType.TypeName =addRoomTypeDto.TypeName;
            roomType.Description =addRoomTypeDto.Description;
            roomType.Capacity =addRoomTypeDto.Capacity;
            _DbContext.RoomTypes.Add(roomType);
            await _DbContext.SaveChangesAsync();
             return roomType;
        }

        public async Task<string> DeleteRoomType(int roomId)
        {
          var  DeleteRoom =await _DbContext.RoomTypes.FirstOrDefaultAsync(r => r.Id == roomId);
            if (DeleteRoom == null) {
                return "Room Type Not Found";
            }
             _DbContext.RoomTypes.Remove(DeleteRoom);
            await _DbContext.SaveChangesAsync();
            return "Deleted Successfully";
        }

        public async Task<List<RoomType>> GetALLRoomType()
        {
            var Roomdetails = await _DbContext.RoomTypes.ToListAsync();

            return Roomdetails;


        }

        public async Task<RoomType> GetRoomTypeById(int id)
        {
            var RoomById = await _DbContext.RoomTypes.FirstOrDefaultAsync(R => R.Id == id);
            if (RoomById == null) {
                return null ;
            }
            return RoomById;
        }

        public async Task<bool> UpdateRoom(int roomId, UpdateRoomTypeDto updateRoomTypeDto)
        {
            var roomUpdateById= await _DbContext.RoomTypes.FirstOrDefaultAsync(R=>R.Id == roomId);
          
            RoomType room = new RoomType();
            roomUpdateById.TypeName=updateRoomTypeDto.TypeName;
            roomUpdateById.Description=updateRoomTypeDto.Description;
            roomUpdateById.Capacity=updateRoomTypeDto.Capacity;
            
            await _DbContext.SaveChangesAsync();
            return true;
        }
    }
}
