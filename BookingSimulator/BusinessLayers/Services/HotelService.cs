﻿using AutoMapper;
using BookingSimulator.BusinessLayers.Models.PostModels;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;
using BookingSimulator.Models;

namespace BookingSimulator.BusinessLayers.Services
{
    public class HotelService : IHotelService
    {
        private readonly IDasHotel _dasHotel;
        private readonly IMapper _mapper;

        public HotelService(IDasHotel dasHotel, IMapper mapper)
        {
            _dasHotel = dasHotel;
            _mapper = mapper;
        }

        public Hotel Create(PostHotelModel postHotelModel)
        {
            return _dasHotel.Add(_mapper.Map<Hotel>(postHotelModel));
        }
    }
}
