using HotelBookingSystem.Appilcation.Employee.Query;
using HotelBookingSystem.Domain.Entities;
using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookingSystem.Application.Employee.Command
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, (string accessToken, string refreshToken)>
    {
        private readonly HotelDbContext _hotelDbContext;
        private readonly JwtTokenGenerator _jwtTokenGenerator;

        public RefreshTokenCommandHandler(HotelDbContext hotelDbContext, JwtTokenGenerator jwtTokenGenerator)
        {
            _hotelDbContext = hotelDbContext;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<(string accessToken, string refreshToken)> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var tokenEntity = await _hotelDbContext.RefreshTokens
                .FirstOrDefaultAsync(t => t.Token == request.RefreshToken && !t.Revoked, cancellationToken);

            if (tokenEntity == null || tokenEntity.ExpiresAt < DateTime.UtcNow)
                throw new UnauthorizedAccessException("Invalid or expired refresh token");

            var employee = await _hotelDbContext.Employees.FindAsync(tokenEntity.EmployeeId);
            if (employee == null)
                throw new UnauthorizedAccessException("User not found");

            var newAccessToken = await _jwtTokenGenerator.GenerateToken(employee.Email);
            var newRefreshToken = _jwtTokenGenerator.GenerateRefreshToken();

            tokenEntity.Revoked = true;

            _hotelDbContext.RefreshTokens.Add(new RefreshToken
            {
                EmployeeId = employee.Id,
                Token = newRefreshToken,
                ExpiresAt = DateTime.UtcNow.AddDays(7),
                CreatedAt = DateTime.UtcNow,
                Revoked = false
            });

            await _hotelDbContext.SaveChangesAsync(cancellationToken);

            return (newAccessToken, newRefreshToken);
        }
    }
}
