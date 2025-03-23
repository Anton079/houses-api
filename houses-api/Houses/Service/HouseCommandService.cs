using apps_api.Houses.Dtos;
using AutoMapper;
using houses_api.Houses.Dtos;
using houses_api.Houses.Exceptions;
using houses_api.Houses.Repository;

namespace houses_api.Houses.Service
{
    public class HouseCommandService: IHouseCommandService
    {
        private IHouseRepo _houseRepo;
        private IMapper _mapper;

        public HouseCommandService(IHouseRepo houseRepo)
        {
            _houseRepo = houseRepo;
        }

        public async Task<HouseResponse> AddHouse(AddHouseRequest request)
        {
            if (request == null) { throw new NullHouseException(); }

            HouseResponse resp = await _houseRepo.CreateHouseAsync(request);

            return resp;
        }

        public async Task<HouseResponse> EditHouse(int id, EditHouseRequest req)
        {
            if (id == -1) { throw new NullIdException(); }

            HouseResponse resp = await _houseRepo.UpdateHouse(id, req);
            return resp;
        }

        public async Task<HouseResponse> DeleteHouse(int id)
        {
            if (id <= 0) { throw new NullIdException(); }

            HouseResponse resp = await _houseRepo.DeleteHosueById(id);

            return resp;
        }
    }
}
