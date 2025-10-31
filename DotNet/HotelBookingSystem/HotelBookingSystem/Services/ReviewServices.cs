using HotelBookingSystem.DataB;
using HotelBookingSystem.Dtos;
using HotelBookingSystem.Interface;
using HotelBookingSystem.models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class ReviewServices:IReviewService
    {
        


            private readonly HotelBookingSystemContex context;

            public ReviewServices(HotelBookingSystemContex context)
            {
                this.context = context;
            }


            public async Task<string> Delete(int Id)
            {
                var DeleteId = await context.Review.Include(p => p.Hotel).Include(r=>r.Customer).FirstOrDefaultAsync(e => e.Id == Id);
                if (DeleteId == null)
                {
                    return "failed";
                }
                context.Review.Remove(DeleteId);
                context.SaveChanges();
                return "Succesfully deleted";
            }

            public async Task<IEnumerable<Review>> GetAll()
            {
                var lists = await context.Review.ToListAsync();
                return lists;
            }

            public async Task<Review> GetById(int Id)
            {
                var roomsList = await context.Review.FirstOrDefaultAsync(r => r.Id == Id);

                if (roomsList == null)
                {
                    return null;
                }

                return roomsList;
            }



            public async Task<bool> Update(int Id, AddUpdateReveiwDto addUpdateReveiwDto)
            {

                var UpdateId = await context.Review.Include(p => p.Hotel).Include(r=>r.Customer).FirstOrDefaultAsync(r => r.Id == Id);
                if (UpdateId == null)
                {
                    return false;
                }
                UpdateId.HotelId = addUpdateReveiwDto.HotelId;
                UpdateId.CustomerId = addUpdateReveiwDto.CustomerId;
                UpdateId.Rating = addUpdateReveiwDto.Rating;
                UpdateId.Comment = addUpdateReveiwDto.Comment;
                UpdateId.ReviewDate = addUpdateReveiwDto.ReviewDate;

                await context.SaveChangesAsync();
                return true;
            }

            public async Task<Review> Add(AddUpdateReveiwDto addUpdateReveiwDto)
            {

                Review UpdateId = new Review();
            UpdateId.HotelId = addUpdateReveiwDto.HotelId;
            UpdateId.CustomerId = addUpdateReveiwDto.CustomerId;
            UpdateId.Rating = addUpdateReveiwDto.Rating;
            UpdateId.Comment = addUpdateReveiwDto.Comment;
            UpdateId.ReviewDate = addUpdateReveiwDto.ReviewDate;
            context.Review.Add(UpdateId);
                await context.SaveChangesAsync();
                return UpdateId;
            }
        }
    }



