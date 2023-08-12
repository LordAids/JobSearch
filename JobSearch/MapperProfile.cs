using AutoMapper;
using SuperJob.API.DTO;

namespace JobSearch
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ApiCityDTO, CityDTO>()
                .ForMember(s => s.Name, s => s.MapFrom(c => c.title))
                .ForMember(s => s.NameEng, s => s.MapFrom(c => c.title_eng));


        }

    }
}
