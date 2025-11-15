using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Appilcation.Rooms.Command
{
    public class DeleteRoomTypeCommandHandler : IRequestHandler<DeleteRoomCommand, string>
    {
        private readonly HotelDbContext hotelDbContext;

        public DeleteRoomTypeCommandHandler(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }
        public async  Task<string> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Rooms room= await hotelDbContext.Room.FirstOrDefaultAsync(r=>r.Id==request.Id);
            if (room == null) {
                return "Room Not Found";
            }
            hotelDbContext.Room.Remove(room);
           int a= hotelDbContext.SaveChanges();
            if (a < 0) {
                return "Failed To delete";
            }
            return $"{request.Id} deleted";
        }
    }
}
