using houses_api.Houses.Dtos;
using houses_api.Houses.Models;
using AutoMapper;
using apps_api.Houses.Dtos;

namespace houses_api.Houses.Mapers
{
    public class HouseMappingProfile : Profile
    {
        public HouseMappingProfile()
        {
            CreateMap<AddHouseRequest, House>();
            CreateMap<EditHouseRequest, House>();
            CreateMap<House, HouseResponse>();

        }
    }
}
