using HotelBookingSystem.Appilcation.Payment.Command;
using HotelBookingSystem.Appilcation.Review.Command;
using HotelBookingSystem.Appilcation.Payment.Dtos;
using HotelBookingSystem.Appilcation.Review.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBookingSystem.Appilcation.Payment.Query;

namespace HotelBookingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator mediator;

        public PaymentController(IMediator mediator)
        {

            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreatePayment(CreatePaymentCommand command)
        {
            return await mediator.Send(command);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentGetByIdDtos>> DeletePayment(int id)
        {
            GetPaymentByIdQuery query = new GetPaymentByIdQuery();
            query.Id = id;
            return await mediator.Send(query);
        }
        [HttpGet]
        public async Task<List<Domain.Entities.Payment>> GetAllPayment()
        {
            GetAllPaymentDetailsQuery query = new GetAllPaymentDetailsQuery();
            return await mediator.Send(query);
        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<string>> UpdatePayment(int id, UpdatePaymentCommand command)
        {
            command.Id = id;
            return await mediator.Send(command);
        }
        [HttpDelete("{id}")]
        public async Task<string> deletePayment(int id)
        {
            DeletePaymentCommand command = new DeletePaymentCommand();
            command.Id = id;
            return await mediator.Send(command);
        }
    }
}
