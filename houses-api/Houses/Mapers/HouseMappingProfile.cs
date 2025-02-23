using houses_api.Houses.Dtos;
using houses_api.Houses.Models;
using AutoMapper;

namespace houses_api.Houses.Mapers
{
    public class HouseMappingProfile : Profile
    {
        public HouseMappingProfile()
        {
            CreateMap<HouseRequest, House>();
            CreateMap<House, HouseResponse>();
        }
    }
}
