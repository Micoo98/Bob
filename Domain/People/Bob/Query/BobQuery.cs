using MediatR;

using AutoMapper;

namespace Bob.Domain.People
{
    public abstract class BobQuery : BobHandler
    {
        public BobQuery(IMapper mapper) : base(mapper) {}
        public class Get : BobQuery, IRequest<BobViewModel>
        {
            public Get(IMapper mapper) : base(mapper) {}
        }

        public class GetAll : BobQuery, IRequest<BobListViewModel>
        {
            public GetAll(IMapper mapper) : base(mapper) {}
        }
    }
}