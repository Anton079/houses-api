using houses_api.Houses.Dtos;
using houses_api.Houses.Models;
using houses_api.Houses.Repository;
using Microsoft.AspNetCore.Mvc;

namespace houses_api.Houses.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HouseController : ControllerBase
    {
        private IHouseRepo _houseRepo;

        public HouseController(IHouseRepo houseRepo)
        {
            _houseRepo = houseRepo;
        }

        [HttpGet("all")]

        public async Task<ActionResult<List<House>>> GetHousesAsync()
        {
            var houses = await _houseRepo.GetHousesAsync();

            return Ok(houses);
        }

        [HttpPost("add")]

        public async Task<ActionResult<HouseResponse>> CreateAsync([FromBody]HouseRequest houseReq)
        {
            HouseResponse houseSaved = await _houseRepo.CreateHouseAsync(houseReq);

            return Ok(houseSaved);
        }
    }
}
