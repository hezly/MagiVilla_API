﻿using AutoMapper;
using MagiVilla_VillaAPI.Models;
using MagiVilla_VillaAPI.Models.DTO;
using MagiVilla_WebAPI.Models;

namespace MagiVilla_VillaAPI.Profiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig() {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>();
            CreateMap<VillaNumberDTO, VillaNumber>();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();

            CreateMap<UserDTO, LocaUser>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
