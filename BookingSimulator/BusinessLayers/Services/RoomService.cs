using AutoMapper;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.BusinessLayers.Services
{
    public class RoomService : IRoomService
    {
        private readonly IDasRoom _dasRoom;
        private readonly IMapper _mapper;

        public RoomService(IDasRoom dasRoom, IMapper mapper)
        {
            _dasRoom = dasRoom;
            _mapper = mapper;
        }
    }
}
