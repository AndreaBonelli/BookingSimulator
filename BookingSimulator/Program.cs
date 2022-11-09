using BookingSimulator.BusinessLayers.Models.Customers;
using BookingSimulator.BusinessLayers.Services;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Context;
using BookingSimulator.Das.DasServices;
using BookingSimulator.Das.Interfaces;
using BookingSimulator.Helpers.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDasHotel, DbDasHotel>();
builder.Services.AddScoped<IDasCustomer, DbDasCustomer>();
builder.Services.AddScoped<IDasRoom, DbDasRoom>();
builder.Services.AddScoped<IDasReview, DbDasReview>();
builder.Services.AddScoped<IDasBooking, DbDasBooking>();

builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IBookingService, BookingService>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<IValidator<PostCustomerModel>, PostCustomersValidator>();

builder.Services.AddDbContext<BookingSimulatorContext>(option => option.UseSqlServer(@"Data Source=MATEBOOKD15;Initial Catalog=BookingSimulator; Integrated Security=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
