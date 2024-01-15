//automapper install 
using GharKiAPI.Models;
using GharKiAPI.Models.DTO;

namespace GharKiAPI.DTOMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NationalPark, NationalprakDto>().RevertMap()
             CreateMap<TrailDTO, Trail>().RevertMap();
        }

    }
}
