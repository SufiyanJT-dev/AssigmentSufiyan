using HotelBookingSystem.Appilcation.Employee.Query;
using HotelBookingSystem.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookingSystem.Application.Employee.Query
{
    public class ValidatePasswordQueryHandler : IRequestHandler<validatePasswordQuery, ActionResult<string>>
    {
        private readonly HotelDbContext _hotelDbContext;
        private readonly IPasswordHasher<Domain.Entities.Employee> _passwordHasher;
        private readonly JwtTokenGenerator _jwtTokenGenerator;
        public ValidatePasswordQueryHandler(
            HotelDbContext hotelDbContext,
            IPasswordHasher<Domain.Entities.Employee> passwordHasher,
            JwtTokenGenerator jwtTokenGenerator)
        {
            _hotelDbContext = hotelDbContext;
            _passwordHasher = passwordHasher;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<ActionResult<string>> Handle(validatePasswordQuery request, CancellationToken cancellationToken)
        {
            var employee = await _hotelDbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == request.Email, cancellationToken);

            if (employee == null)
            {
                return new OkObjectResult("Invalid Email");
            }

            var result = _passwordHasher.VerifyHashedPassword(employee, employee.password, request.Password);

            if (result == PasswordVerificationResult.Success)
            {
                var refershToken = _jwtTokenGenerator.GenerateRefreshToken();
                var token =  _jwtTokenGenerator.GenerateToken(employee.Email);
                return new OkObjectResult(token, refershToken);
            }
            else
            {
                return new OkObjectResult("Invalid Password");
            }
        }

    }
}
