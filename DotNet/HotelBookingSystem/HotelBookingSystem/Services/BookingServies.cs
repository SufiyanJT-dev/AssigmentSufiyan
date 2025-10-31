using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HotelBookingSystem.Services
{
    public class BookingServies : IBookingSerivce
    {


        private readonly HotelBookingSystemContex context;

        public BookingServies(HotelBookingSystemContex context)
        {
            this.context = context;
        }


        public async Task<string> Delete(int Id)
        {
            var DeleteId = await context.Bookings.Include(e => e.Customer).FirstOrDefaultAsync(e => e.Id == Id);
            if (DeleteId == null)
            {
                return "failed";
            }
            context.Bookings.Remove(DeleteId);
            context.SaveChanges();
            return "Succesfully deleted";
        }

        public async Task<IEnumerable<Booking>> GetAll()
        {
            var lists = await context.Bookings.ToListAsync();
            return lists;
        }

        public async Task<Booking> GetById(int roomId)
        {
            var roomsList = await context.Bookings.FirstOrDefaultAsync(r => r.Id == roomId);

            if (roomsList == null)
            {
                return null;
            }

            return roomsList;
        }



        public async Task<bool> Update(int Id, AddUpdateBookingDto addUpdateBooking)
        {

            var UpdateId = await context.Bookings.Include(r => r.CustomerId).FirstOrDefaultAsync(r => r.Id == Id);
            if (UpdateId == null)
            {
                return false;
            }
            UpdateId.CheckInDate = addUpdateBooking.CheckInDate;
            UpdateId.CheckOutDate = addUpdateBooking.CheckOutDate;
            UpdateId.CustomerId = addUpdateBooking.CustomerId;
            UpdateId.RoomId = addUpdateBooking.RoomId;
            UpdateId.Status = addUpdateBooking.Status;
            UpdateId.TotalAmount = addUpdateBooking.TotalAmount;
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Booking> Add(AddUpdateBookingDto addUpdateBooking)
        {
            Booking UpdateId = new Booking();
            UpdateId.CheckInDate = addUpdateBooking.CheckInDate;
            UpdateId.CheckOutDate = addUpdateBooking.CheckOutDate;
            UpdateId.CustomerId = addUpdateBooking.CustomerId;
            UpdateId.RoomId = addUpdateBooking.RoomId;
            UpdateId.Status = addUpdateBooking.Status;
            UpdateId.TotalAmount = addUpdateBooking.TotalAmount;
            context.Bookings.Add(UpdateId);
            await context.SaveChangesAsync();
            return UpdateId;
        }
    }
}




