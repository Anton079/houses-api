using houses_api.Houses.Dtos;
using houses_api.Houses.Models;

namespace houses_api.Houses.Repository
{
    public interface IHouseRepo
    {
        Task<List<House>> GetHousesAsync();
        Task<HouseResponse> CreateHouseAsync(HouseRequest houseReq);
    }
}
