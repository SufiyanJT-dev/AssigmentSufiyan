using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly HotelBookingSystemContex _context;
        public HotelServices(HotelBookingSystemContex context)
        {
            _context = context;

        }
        public async Task<AddHotelDto> AddHotel(AddHotelDto addHotelDto)
        {
            var hotel = new Hotel();
            hotel.Name = addHotelDto.Name;
            hotel.Address = addHotelDto.Address;
            hotel.PhoneNumber = addHotelDto.PhoneNumber;
            hotel.City = addHotelDto.City;
            hotel.Country = addHotelDto.Country;
            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return addHotelDto;


        }

        public async Task<string> DeleteHotel(int id)
        {
           
           var HotelDelete=await _context.Hotels.FirstOrDefaultAsync(h=>h.Id == id);
            if (HotelDelete==null) {
                return "Hotel Not Found";
            }
            _context.Hotels.Remove(HotelDelete);
            await _context.SaveChangesAsync();
            return "Successfull";
           
        }

        public async Task<List<Hotel>> SelectAllHotel()
        {
            var Hotols=  await _context.Hotels
                .Include(h => h.Room)
                .Include(h => h.Employees)
                
                .ToListAsync();
            if (Hotols.Count == 0) return new List<Hotel>();
            return Hotols;
        }

        public async Task<Hotel> SelectById(int id)

        {
            
            var HotelIdDetails= await _context.Hotels.FirstOrDefaultAsync(h => h.Id == id);
            if (HotelIdDetails ==null) { 
            return HotelIdDetails;
            }
            return HotelIdDetails;
        }

        public async Task<bool> UpdateHotel(int id, AddHotelDto addHotelDto)
        {
           
         
            var HotelIdCheck = _context.Hotels.FirstOrDefault(h => h.Id == id);
            if (HotelIdCheck == null) {
                return false;
            }
            HotelIdCheck.Name=addHotelDto.Name;
            HotelIdCheck.Address=addHotelDto.Address;
            HotelIdCheck.PhoneNumber=addHotelDto.PhoneNumber;
            HotelIdCheck.City=addHotelDto.City;
            HotelIdCheck.Country=addHotelDto.Country;
           await _context.SaveChangesAsync();
            return true;

        }
        



    }
}