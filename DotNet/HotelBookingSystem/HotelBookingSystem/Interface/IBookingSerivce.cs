using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
    public interface  IBookingSerivce
    {
        public Task<IEnumerable<Booking>> GetAll();
        public Task<Booking> GetById(int Id);
        public Task<string> Delete(int Id);
        public Task<bool> Update(int Id, AddUpdateBookingDto addUpdateBooking);
        public Task<Booking> Add(AddUpdateBookingDto addUpdateBooking);
    }
}
