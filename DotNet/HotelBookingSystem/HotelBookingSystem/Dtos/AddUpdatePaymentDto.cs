using HotelBookingSystem.models;

namespace HotelBookingSystem.Dtos
{
    public class AddUpdatePaymentDto
    {
        public int BookingId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }


    }
}
