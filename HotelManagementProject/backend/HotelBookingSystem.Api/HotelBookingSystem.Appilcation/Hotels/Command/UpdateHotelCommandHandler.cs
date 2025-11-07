using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookingSystem.Appilcation.Hotels.Command
{
    public class UpdateHotelCommandHandler : IRequestHandler<UpdateHotelCommand, string>
    {
        private readonly HotelDbContext hotelDbContext;

        public UpdateHotelCommandHandler(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }

        public async Task<string> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
        {
            var hotel = await hotelDbContext.Hotels.FirstOrDefaultAsync(h => h.Id == request.Id, cancellationToken);
            if (hotel == null)
            {
                return "Hotel ID not found";
            }

            
            hotel.Name = !string.IsNullOrWhiteSpace(request.Name) && request.Name != "string"
                ? request.Name
                : hotel.Name;

            hotel.Address = !string.IsNullOrWhiteSpace(request.Address) && request.Address != "string"
                ? request.Address
                : hotel.Address;

            hotel.City = !string.IsNullOrWhiteSpace(request.City) && request.City != "string"
                ? request.City
                : hotel.City;

            hotel.Country = !string.IsNullOrWhiteSpace(request.Country) && request.Country != "string"
                ? request.Country
                : hotel.Country;

            hotel.PhoneNumber = !string.IsNullOrWhiteSpace(request.PhoneNumber) && request.PhoneNumber != "string"
                ? request.PhoneNumber
                : hotel.PhoneNumber;

            int result = await hotelDbContext.SaveChangesAsync(cancellationToken);
            return result > 0 ? "Update Successful" : "Update Not Successful";
        }
    }
}
