using apps_api.Houses.Dtos;
using houses_api.Houses.Dtos;

namespace houses_api.Houses.Service
{
    public interface IHouseCommandService
    {
        Task<HouseResponse> AddHouse(AddHouseRequest houseRequest);

        Task<HouseResponse> EditHouse(int id, EditHouseRequest req);
    }
}
