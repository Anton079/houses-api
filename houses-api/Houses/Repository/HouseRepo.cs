using apps_api.Houses.Dtos;
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

        public async Task<HouseResponse> CreateHouseAsync(AddHouseRequest houseReq)
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

        public async Task<List<House>> GetMinPrice(int min)
        {
            return await _appDbContext.Houses.Where(house => house.price > min).ToListAsync();
        }

        public async Task<List<House>> GetMinMaxPrice(int min, int max)
        {
            return await _appDbContext.Houses.Where(house => house.price > min && house.price < max).ToListAsync();
        }

        public async Task<HouseResponse> DeleteHosueById(int id)
        {
            House house = await _appDbContext.Houses.FindAsync(id);

            HouseResponse houseResponse = _mapper.Map<HouseResponse>(house);

            _appDbContext.Houses.Remove(house);

            await _appDbContext.SaveChangesAsync();

            return houseResponse;
        }

        public async Task<HouseResponse> UpdateHouse(int id, EditHouseRequest houseRequest)
        {
            var house = await _appDbContext.Houses.FindAsync(id);


            house.model = houseRequest.Type ?? house.model;
            house.rooms = houseRequest.Rooms ?? house.rooms;
            house.price = houseRequest.Price ?? house.price;

            _appDbContext.Houses.Update(house);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<HouseResponse>(house);


        }
    }
}
