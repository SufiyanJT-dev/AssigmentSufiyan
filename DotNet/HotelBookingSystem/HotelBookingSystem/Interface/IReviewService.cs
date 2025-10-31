using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
    public interface  IReviewService
    {
        public Task<IEnumerable<Review>> GetAll();
        public Task<Review> GetById(int Id);
        public Task<string> Delete(int Id);
        public Task<bool> Update(int Id, AddUpdateReveiwDto addUpdateReveiwDto);
        public Task<Review> Add(AddUpdateReveiwDto addUpdateReveiwDto);
    }
}
