namespace HotelBookingSystem.models
{
    using System.Collections.Generic;

    public class Rooms
    {
        public enum RoomStatus
        {
            Available,
            Booked,
            UnderMaintenance
        }
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }

        
        public Hotel Hotel { get; set; }
        public RoomType RoomType { get; set; }
        public List<Booking> Bookings { get; set; }
    }
   



}
