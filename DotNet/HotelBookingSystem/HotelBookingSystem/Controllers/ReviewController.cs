using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
       
            private readonly IReviewService reviewService;

            public ReviewController(IReviewService reviewService)
            {
                this.reviewService = reviewService;
            }
            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var GetRoom = await reviewService.GetAll();
                return Ok(GetRoom);
            }
            [HttpPost]
            public async Task<IActionResult> Add(AddUpdateReveiwDto addUpdateReveiwDto)
            {
                var Add = await reviewService.Add(addUpdateReveiwDto);
                return Ok(Add);

            }
            [HttpGet("{id}")]
            public async Task<IActionResult> GetByID(int id)
            {
                var GetByID = await reviewService.GetById(id);
                return Ok(GetByID);

            }
            [HttpPut("{id}")]
            public async Task<IActionResult> Update(int id, AddUpdateReveiwDto addUpdateReveiwDto)
            {
                var UpdateID = await reviewService.Update(id, addUpdateReveiwDto);


                return Ok(UpdateID);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                return Ok(await reviewService.Delete(id));


            }
        }
    }

