using AutoMapper;
using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.DasServices;
using BookingSimulator.Das.Interfaces;

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

        public Hotel Create(PostPutHotelModel postHotelModel)
        {
            return _dasHotel.Add(_mapper.Map<Hotel>(postHotelModel));
        }

        public Hotel Update(int id, PostPutHotelModel hotel)
        {
            try
            {
                var hotelToUpdate = _dasHotel.GetById(id);
                hotelToUpdate.Name = hotel.Name;
                return _dasHotel.Update(hotelToUpdate);
            }
            catch
            {
                var hoteltoUpdate = _mapper.Map<Hotel>(hotel);
                return _dasHotel.Add(hoteltoUpdate);
            }
            
        }
    }
}
