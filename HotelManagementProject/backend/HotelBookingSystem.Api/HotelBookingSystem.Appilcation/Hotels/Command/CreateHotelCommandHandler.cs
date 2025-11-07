using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookingSystem.Appilcation.Hotels.Command
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, ActionResult<string>>
    {
        private readonly HotelDbContext hotelDbContext;

        public CreateHotelCommandHandler(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }

        public async Task<ActionResult<string>> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            try
            {
              
              
                if (string.IsNullOrWhiteSpace(request.Name) ||
                    string.IsNullOrWhiteSpace(request.Address) ||
                    string.IsNullOrWhiteSpace(request.City) ||
                    string.IsNullOrWhiteSpace(request.PhoneNumber) ||
                    string.IsNullOrWhiteSpace(request.Country))
                {
                    return new BadRequestObjectResult("All fields are required. Please provide valid hotel details.");
                }

                var hotel = new Domain.Entities.Hotel
                {
                    Name = request.Name,
                    Address = request.Address,
                    City = request.City,
                    PhoneNumber = request.PhoneNumber,
                    Country = request.Country
                };

                hotelDbContext.Hotels.Add(hotel);
                int result = await hotelDbContext.SaveChangesAsync(cancellationToken);

                if (result <= 0)
                {
                    return new BadRequestObjectResult("Hotel was not added. Please try again.");
                }

                return new OkObjectResult("Hotel added successfully.");
            }
            catch (Exception ex)
            {
                return new ObjectResult($"Unexpected error: {ex.Message}") { StatusCode = 500 };
            }
        }
    }
}
