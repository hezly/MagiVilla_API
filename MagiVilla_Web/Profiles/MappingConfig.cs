using AutoMapper;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;

namespace MagiVilla_Web.Profiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<VillaModel, VillaDTO>().ReverseMap();
            CreateMap<VillaModel, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaModel, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaUpdateDTO, VillaDTO>().ReverseMap();

            CreateMap<VillaNumberModel, VillaNumberDTO>();
            CreateMap<VillaNumberDTO, VillaNumberModel>();
            CreateMap<VillaNumberModel, VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberModel, VillaNumberCreateDTO>().ReverseMap();
        }
    }
}
