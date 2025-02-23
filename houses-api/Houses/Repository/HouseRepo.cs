using AutoMapper;
using houses_api.Data.Migrations;
using houses_api.Houses.Dtos;
using houses_api.Houses.Models;
using Microsoft.EntityFrameworkCore;

namespace houses_api.Houses.Repository
{
    public class HouseRepo : IHouseRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public HouseRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<HouseResponse> CreateHouseAsync(HouseRequest houseReq)
        {
            House house = _mapper.Map<House>(houseReq);

            _appDbContext.Houses.Add(house);

            await _appDbContext.SaveChangesAsync();

            HouseResponse response = _mapper.Map<HouseResponse>(house);

            return response;
        }

        public async Task<List<House>> GetHousesAsync()
        {
            return await _appDbContext.Houses.ToListAsync();
        }
    }
}
