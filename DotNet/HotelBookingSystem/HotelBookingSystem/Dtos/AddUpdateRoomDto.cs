using System.Diagnostics.CodeAnalysis;
using static HotelBookingSystem.models.Rooms;

namespace HotelBookingSystem.Dtos
{
    public class AddUpdateRoomDto
    {
    
    
        public string RoomNumber { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }


        }

    }

