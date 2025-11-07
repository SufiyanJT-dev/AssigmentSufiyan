using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Appilcation.Employee.Command
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private readonly HotelDbContext hotelDbContext;

        public CreateEmployeeCommandHandler(HotelDbContext hotelDbContext) {
            this.hotelDbContext = hotelDbContext;
        }
        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(request.FullName) ||
                    string.IsNullOrWhiteSpace(request.Email) ||
                    string.IsNullOrWhiteSpace(request.Role) ||
                    request.HotelId <= 0)
                {
                    return "All fields are required. Please provide valid data.";
                }

                var employee = new Domain.Entities.Employee
                {
                    Email = request.Email,
                    HotelId = request.HotelId,
                    FullName = request.FullName,
                    Role = request.Role
                };

                await hotelDbContext.Employees.AddAsync(employee, cancellationToken);
                int result = await hotelDbContext.SaveChangesAsync(cancellationToken);

                if (result <= 0)
                {
                    return "Employee was not added. Please try again.";
                }

                return "Employee added successfully.";
            }
            catch (DbUpdateException dbEx)
            {
                return $"Database error occurred: {dbEx.Message}";
            }
            catch (Exception ex)
            {
                return $"An unexpected error occurred: {ex.Message}";
            }
        }

    }
}
