//automapper install 
using AutoMapper;
using GharKiAPI.Models;
using GharKiAPI.Models.DTO;

namespace GharKiAPI.DTOMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NationalPark, NationalParkDTO>().ReverseMap();
            CreateMap<TrailDTO, Trail>().ReverseMap();
        }

    }
}
