using HotelBookingSystem.DataB;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerService,CustomerServices>();
builder.Services.AddScoped<IHotelServices, HotelServices>();
builder.Services.AddScoped<IRoomTypeServies, RoomTypeServices>();
builder.Services.AddScoped<IRoomSerices, RoomSerices>();
builder.Services.AddScoped<IBookingSerivce,BookingServies>() ;
builder.Services.AddScoped<IPaymentServices, PaymentServices>();
builder.Services.AddScoped<IReviewService, ReviewServices>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServies>();
// Add DbContext
string ConString = "Server=localhost;Database=HotelBookingSystem;User Id=sa;Password=Sufiyan@123;TrustServerCertificate=True;";
builder.Services.AddDbContext<HotelBookingSystemContex>(options =>
    options.UseSqlServer(ConString));

var app = builder.Build();

// Enable Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
