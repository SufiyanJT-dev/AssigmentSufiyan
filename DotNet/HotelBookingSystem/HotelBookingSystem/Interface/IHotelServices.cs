using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
   public  interface  IHotelServices
    {
        public Task<AddHotelDto> AddHotel(AddHotelDto addHotelDto);
        public Task<bool> UpdateHotel(int id, AddHotelDto addHotelDto);
        public Task<string> DeleteHotel(int id);
        public Task<List<Hotel>> SelectAllHotel();
        public Task<Hotel> SelectById(int id);

          
    }
}
