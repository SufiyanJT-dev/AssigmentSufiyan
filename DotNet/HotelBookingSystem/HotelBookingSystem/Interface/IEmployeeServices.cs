using HotelBookingSystem.Dtos;
using HotelBookingSystem.models;

namespace HotelBookingSystem.Interface
{
    public  interface IEmployeeServices
    {

        public Task<IEnumerable<Employee>> GetAll();
        public Task<Employee> GetById(int Id);
        public Task<string> Delete(int Id);
        public Task<bool> Update(int Id, AddUpdateEmployeeDto addUpdateEmployeeDto);
        public Task<Employee> Add(AddUpdateEmployeeDto addUpdateEmployeeDto);
    }
}

