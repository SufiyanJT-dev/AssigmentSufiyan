using HotelBookingSystem.models;

namespace HotelBookingSystem.Dtos
{
    public class AddUpdateBookingDto
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public BookingStatus Status { get; set; }
        public decimal TotalAmount { get; set; }


    }
}
