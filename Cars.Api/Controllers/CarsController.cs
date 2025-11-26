using Cars.Application.DTO;
using Cars.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cars.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase    
    {
        private readonly ICarsService _carsService;

        public CarsController(ICarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] CarsDto carsDto)
        {
            if (carsDto == null)
            {
                return BadRequest("Balance cannot be null.");
            }

            await _carsService.AddCarAsync(carsDto);
            return Ok();
        }

        [HttpGet("GetAllCars", Name = "GetAllCars")]
        public async Task<IActionResult> GetAllCars()
        {
            var response = await _carsService.GetALlCars();

            return Ok(response);
        }

        [HttpGet("{guid}", Name = "GetCarById")]
        public async Task<IActionResult> GetCarById([FromRoute] Guid guid)
        {
            var response = await _carsService.GetCarById(guid);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBalanceAnalysis(Guid id, [FromBody] CarsDto balanceAnalysisDto)
        {
            balanceAnalysisDto.CarId = id;
            await _carsService.UpdateCarAsync(id, balanceAnalysisDto);
            return Ok();
        }

        [HttpDelete]
        public async Task DeleteBalanceAnalysis([FromQuery] Guid guid)
        {
            await _carsService.DeleteCarAsync(guid);
        }
    }
}
