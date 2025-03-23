using apps_api.Houses.Dtos;
using houses_api.Houses.Dtos;
using houses_api.Houses.Models;

namespace houses_api.Houses.Repository
{
    public interface IHouseRepo
    {
        Task<List<House>> GetHousesAsync();

        Task<HouseResponse> CreateHouseAsync(AddHouseRequest houseReq);

        Task<List<House>> GetMinPrice(int min);

        Task<List<House>> GetMinMaxPrice(int min, int max);

        Task<HouseResponse> DeleteHosueById(int id);

        Task<HouseResponse> UpdateHouse(int id, EditHouseRequest houseRequest);
    }
}
