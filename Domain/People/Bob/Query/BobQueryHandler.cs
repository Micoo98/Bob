using MediatR;

using AutoMapper;

using System.Threading.Tasks;

using System.Threading;

using System.Collections.Generic;

namespace Bob.Domain.People
{
    public class BobQueryHandler  : BobHandler
    {
        public BobQueryHandler(IMapper mapper) : base(mapper) {}
        public class Get : BobQueryHandler, IRequestHandler<BobQuery.Get, BobViewModel>
        {
            public Get(IMapper mapper) : base(mapper) {}


            public async Task<BobViewModel> Handle(BobQuery.Get request, CancellationToken token)
            {
                BobRecord record = null;
                await Task.Run(() => record = new BobRecord{
                    Name = "Bobbo",
                    PreferedHairStyle = "None",
                    Funds = 35.35m
                });

                return _mapper.Map<BobViewModel>(record);
            }
        }

        public class GetAll : BobQueryHandler, IRequestHandler<BobQuery.GetAll, BobListViewModel>
        {
            public GetAll(IMapper mapper) : base(mapper) {}

            public async Task<BobListViewModel> Handle(BobQuery.GetAll request, CancellationToken token)
            {
                IEnumerable<BobRecord> records = null;
                await Task.Run(() => records = new List<BobRecord>{
                    new BobRecord {
                        Name = "Bobbo",
                        PreferedHairStyle = "None",
                        Funds = 34.34m
                    },
                    new BobRecord {
                        PreferedHairStyle = "None"
                    },
                    new BobRecord{
                        Funds = 34.34m
                    },
                });

                return _mapper.Map<BobListViewModel>(records);
        }
    }
}
}