using AutoMapper;

namespace Bob.Domain.People
{

    public abstract class BobHandler
    {
        protected readonly IMapper _mapper;


        public BobHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}