using AutoMapper;

using System.Collections.Generic;

namespace Bob.Domain.People
{
    public class BobListProfile : Profile
    {
        public BobListProfile()
        {
            CreateMap<IEnumerable<BobRecord>, BobListViewModel>()
                .ForMember(destination => destination.Responce, source => source.MapFrom(x => x));
        }
    }
}