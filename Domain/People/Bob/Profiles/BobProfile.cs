using AutoMapper;

namespace Bob.Domain.People
{
    public class BobProfile : Profile
    {
        public BobProfile()
        {
            CreateMap<BobRecord, BobViewModel>()
                .ForMember(destination => destination.Responce, source => source.MapFrom(x => x));
        }
    }
}