using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
    public interface IPaymentServices
    {
        public Task<IEnumerable<Payment>> GetAll();
        public Task<Payment> GetById(int Id);
        public Task<string> Delete(int Id);
        public Task<bool> Update(int Id, AddUpdatePaymentDto addUpdatePaymentDto);
        public Task<Payment> Add(AddUpdatePaymentDto addUpdatePaymentDto);
    }
}
