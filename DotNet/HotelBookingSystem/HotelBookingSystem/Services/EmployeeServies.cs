using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class EmployeeServies:IEmployeeServices
    {

     
            private readonly HotelBookingSystemContex context;

            public EmployeeServies(HotelBookingSystemContex context)
            {
                this.context = context;
            }


            public async Task<string> Delete(int Id)
            {
                var DeleteId = await context.Employees.Include(e=>e.Hotel).FirstOrDefaultAsync(e=>e.Id==Id);
                if (DeleteId == null)
                {
                    return "failed";
                }
                context.Employees.Remove(DeleteId);
                context.SaveChanges();
                return "Succesfully deleted";
            }

            public async Task<IEnumerable<Employee>> GetAll()
            {
                var lists = await context.Employees.ToListAsync();
                return lists;
            }

            public async Task<Employee> GetById(int roomId)
            {
                var roomsList = await context.Employees.FirstOrDefaultAsync(r => r.Id == roomId);

            if (roomsList == null) { 
            return null;
            }

                return roomsList;
            }



            public async Task<bool> Update(int roomId, AddUpdateEmployeeDto addUpdateEmployee)
            {

                var RoomUpdateId = await context.Employees.FirstOrDefaultAsync(r => r.Id == roomId);
                if (RoomUpdateId == null)
                {
                    return false;
                }
                RoomUpdateId.FullName = addUpdateEmployee.FullName;
                RoomUpdateId.HotelId = addUpdateEmployee.HotelId;
                RoomUpdateId.Email = addUpdateEmployee.Email;
                RoomUpdateId.Role = addUpdateEmployee.Role;

            await context.SaveChangesAsync();
            return true;
            }

            public async Task<Employee> Add(AddUpdateEmployeeDto addUpdateEmployee)
            {
                Employee RoomUpdateId = new Employee();
            RoomUpdateId.FullName = addUpdateEmployee.FullName;
            RoomUpdateId.HotelId = addUpdateEmployee.HotelId;
            RoomUpdateId.Email = addUpdateEmployee.Email;
            RoomUpdateId.Role = addUpdateEmployee.Role;

                context.Employees.Add(RoomUpdateId);
                await context.SaveChangesAsync();
                return RoomUpdateId;
            }
        }
    }


