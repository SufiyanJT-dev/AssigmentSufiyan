namespace HotelBookingSystem.Domain.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool Revoked { get; set; }
        public DateTime CreatedAt { get; set; }

        public Employee Employee { get; set; }
    }
}