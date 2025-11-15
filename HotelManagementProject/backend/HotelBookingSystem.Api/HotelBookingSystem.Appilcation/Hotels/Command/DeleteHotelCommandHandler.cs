using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Appilcation.Hotels.Command
{
    public class DeleteHotelCommandHandler : IRequestHandler<DeleteHotelCommand, string>
    {
        private readonly HotelDbContext hotelDbContext;

        public DeleteHotelCommandHandler(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }
        public async  Task<string> Handle(DeleteHotelCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Hotel hotel = await hotelDbContext.Hotels.FirstOrDefaultAsync(h => h.Id == request.Id, cancellationToken);
            if (hotel==null)
            {
                return "Employee Not FOund";
            }
            hotelDbContext.Hotels.Remove(hotel);
           int a= hotelDbContext.SaveChanges();
            if (a < 0) {
                return "Failed To delete";
            }
            return $"{request.Id} deleted";
        }
    }
}
