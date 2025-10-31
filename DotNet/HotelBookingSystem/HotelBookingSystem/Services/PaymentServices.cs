using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class PaymentServices:IPaymentServices

    {

        private readonly HotelBookingSystemContex context;

        public PaymentServices(HotelBookingSystemContex context)
        {
            this.context = context;
        }


        public async Task<string> Delete(int Id)
        {
            var DeleteId = await context.Payments.Include(p=>p.Booking).FirstOrDefaultAsync(e => e.Id == Id);
            if (DeleteId == null)
            {
                return "failed";
            }
            context.Payments.Remove(DeleteId);
            context.SaveChanges();
            return "Succesfully deleted";
        }

        public async Task<IEnumerable<Payment>> GetAll()
        {
            var lists = await context.Payments.ToListAsync();
            return lists;
        }

        public async Task<Payment> GetById(int Id)
        {
            var roomsList = await context.Payments.FirstOrDefaultAsync(r => r.Id == Id);

            if (roomsList == null)
            {
                return null;
            }

            return roomsList;
        }



        public async Task<bool> Update(int Id, AddUpdatePaymentDto addUpdatePaymentDto)
        {

            var UpdateId = await context.Payments.Include(p=>p.Booking).FirstOrDefaultAsync(r => r.Id == Id);
            if (UpdateId == null)
            {
                return false;
            }
            UpdateId.Status = addUpdatePaymentDto.Status;
            UpdateId.Amount = addUpdatePaymentDto.Amount;
            UpdateId.Method = addUpdatePaymentDto.Method;
            UpdateId.BookingId = addUpdatePaymentDto.BookingId;
            UpdateId.PaymentDate = addUpdatePaymentDto.PaymentDate;
           
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Payment> Add(AddUpdatePaymentDto addUpdatePaymentDto)
        {

            Payment UpdateId=new Payment();
            UpdateId.Status = addUpdatePaymentDto.Status;
            UpdateId.Amount = addUpdatePaymentDto.Amount;
            UpdateId.Method = addUpdatePaymentDto.Method;
            UpdateId.BookingId = addUpdatePaymentDto.BookingId;
            UpdateId.PaymentDate = addUpdatePaymentDto.PaymentDate;
            context.Payments.Add(UpdateId);
            await context.SaveChangesAsync();
            return UpdateId;
        }
    }
}
