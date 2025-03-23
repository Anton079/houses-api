using apps_api.Houses.Dtos;
using houses_api.Houses.Dtos;
using houses_api.Houses.Exceptions;
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

        public async Task<ActionResult<HouseResponse>> CreateAsync([FromBody]AddHouseRequest houseReq)
        {
            try
            {
                HouseResponse houseSaved = await _houseRepo.CreateHouseAsync(houseReq);

                return Ok(houseSaved);
            }
            catch (HouseExistException ex) {return BadRequest(ex.Message); }
        }

        [HttpDelete("deleteHouse")]

        public async Task<ActionResult<HouseResponse>> DeleteHouseById([FromQuery] int id)
        {
            var house = await _houseRepo.DeleteHosueById(id);

            return Ok(house);
        }

        [HttpPut("UpdateHouse")]

        public async Task<ActionResult<HouseResponse>> UpdateHouse([FromQuery] int id, [FromBody] EditHouseRequest houseReq)
        {
            HouseResponse house = await _houseRepo.UpdateHouse(id, houseReq);

            return Ok(house);
        }
    }
}
