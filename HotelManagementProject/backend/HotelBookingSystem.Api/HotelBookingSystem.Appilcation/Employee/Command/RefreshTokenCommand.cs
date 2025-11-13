using MediatR;

namespace HotelBookingSystem.Application.Employee.Command
{
    public class RefreshTokenCommand : IRequest<(string accessToken, string refreshToken)>
    {
        public string RefreshToken { get; set; }
    }
}
