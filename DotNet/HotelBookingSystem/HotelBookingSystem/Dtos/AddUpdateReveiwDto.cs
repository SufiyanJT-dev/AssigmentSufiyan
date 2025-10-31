namespace HotelBookingSystem.Dtos
{
    public class AddUpdateReveiwDto
    {
        public int HotelId { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

    }
}
