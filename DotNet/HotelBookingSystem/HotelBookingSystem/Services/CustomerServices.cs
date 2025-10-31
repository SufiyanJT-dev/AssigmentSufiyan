using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly HotelBookingSystemContex _DbContex;
        public CustomerServices(HotelBookingSystemContex DbContex)
        {
            _DbContex = DbContex;
        }
        public async Task<AddCustomerdto> AddAsycCustomer(AddCustomerdto addCustomerdto )
        {
            Customer customer = new Customer();
            customer.FullName = addCustomerdto.FullName;
            customer.PhoneNumber = addCustomerdto.PhoneNumber;
            customer.Email = addCustomerdto.Email;
            customer.IdProofNumber = addCustomerdto.IdProofNumber;
             _DbContex.Customers.Add(customer);
            await _DbContex.SaveChangesAsync();
            return addCustomerdto;
        }
        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _DbContex.Customers.ToListAsync();

        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _DbContex.Customers.FirstOrDefaultAsync(c => c.Id == id);

        }
        public async Task<bool> UpdateCustomerById(int id,UpdateCustomerDto updateCustomerDto )
        {
            
            var UpdateCustomerbyID = await _DbContex.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (UpdateCustomerbyID == null)
            {
                return false;
            }
            UpdateCustomerbyID.FullName = updateCustomerDto.FullName;
            updateCustomerDto.Email = updateCustomerDto.Email;
            updateCustomerDto.PhoneNumber = updateCustomerDto.PhoneNumber;
           await _DbContex.SaveChangesAsync();
            return true;
           
        }
        public async Task<bool> DeleteCustomer(int id)
        {
            var Customer = await _DbContex.Customers.FirstOrDefaultAsync(c => c.Id == 1);
            if (Customer == null)
            {
                return false;
            }
            _DbContex.Customers.Remove(Customer);
            await _DbContex.SaveChangesAsync();
            return true;

        }

    }
}
