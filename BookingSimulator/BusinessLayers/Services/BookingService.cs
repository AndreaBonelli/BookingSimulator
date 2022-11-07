﻿using AutoMapper;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.BusinessLayers.Services
{
    public class BookingService : IBookingService
    {
        private readonly IDasBooking _dasBooking;
        private readonly IMapper _mapper;

        public BookingService(IDasBooking dasBooking, IMapper mapper)
        {
            _dasBooking = dasBooking;
            _mapper = mapper;
        }
    }
}