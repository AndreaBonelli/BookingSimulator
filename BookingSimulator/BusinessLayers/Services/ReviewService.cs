using AutoMapper;
using BookingSimulator.BusinessLayers.Services.Interfaces;
using BookingSimulator.Das.Interfaces;

namespace BookingSimulator.BusinessLayers.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IDasReview _dasReview;
        private readonly IMapper _mapper;

        public ReviewService(IDasReview dasReview, IMapper mapper)
        {
            _dasReview = dasReview;
            _mapper = mapper;
        }
    }
}
