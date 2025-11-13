using HotelBookingSystem.Appilcation.Employee.Command;
using HotelBookingSystem.Appilcation.Employee.Dtos;
using HotelBookingSystem.Appilcation.Employee.Query;
using HotelBookingSystem.Application.Employee.Command;
using HotelBookingSystem.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
       
        [HttpPost]
        public async Task<string> CreateEmployee(CreateEmployeeCommand command)
        {
            return await mediator.Send(command);
        }
        [Authorize]
        [HttpGet]
        public async Task<List<Domain.Entities.Employee>> GetEmployeeAsync()
        {
            GetAllEmployeeQuery query = new GetAllEmployeeQuery();
            return await mediator.Send(query);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeGetByIdDtos>> getByIdEmployee(int id)
        {
            GetEmployeeByIdQuery query = new GetEmployeeByIdQuery();
            query.Id = id;
            return await mediator.Send(query);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteRoomType(int id)
        {
            DeleteEmployeeCommand command = new DeleteEmployeeCommand();

            command.Id = id;
            return await mediator.Send(command);

        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<string>> UpdateRoomType(UpdateEmployeeCommand command, int id)
        {

            command.Id = id;
            return await mediator.Send(command);
        }
        [HttpPost("validate-login")]

       
        public async Task<IActionResult> ValidatingLogin([FromBody] validatePasswordQuery query)
        {
            var (accessToken, refreshToken) = await mediator.Send(query);

            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(refreshToken))
            {
                return Unauthorized("Invalid credentials.");
            }

            Response.Cookies.Append("refreshToken", refreshToken, new CookieOptions
            {
                HttpOnly = true,
                Secure = false,
                SameSite = SameSiteMode.Lax,
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddDays(7)
            });

            return Ok(new { accessToken,refreshToken  });
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommand command)
        {
            var refreshToken = command.RefreshToken;
            if (string.IsNullOrEmpty(refreshToken))
                return Unauthorized("Refresh token missing");

            try
            {
                var (accessToken, newRefreshToken) = await mediator.Send(new RefreshTokenCommand { RefreshToken = refreshToken });

                Response.Cookies.Append("refreshToken", newRefreshToken, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = false,
                    SameSite = SameSiteMode.Lax,
                    Path = "/",
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                });

                return Ok(new { accessToken });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}