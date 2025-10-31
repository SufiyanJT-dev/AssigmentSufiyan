using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Services
{
    public interface ICustomerService
    {
        Task<AddCustomerdto> AddAsycCustomer(AddCustomerdto addCustomerdto);
        Task<List<Customer>> GetAllCustomer();
        Task<Customer> GetCustomerById(int id);
        Task<bool> UpdateCustomerById(int id,UpdateCustomerDto updateCustomerDto);
        Task<bool> DeleteCustomer(int id);

    }
}
