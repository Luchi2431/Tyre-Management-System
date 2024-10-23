using Microsoft.AspNetCore.Mvc;
using TMS.Data.DTO;
using TMS.Data.Models;
using TMS.Data.Services.Interfaces;

namespace TMS.Api.Controllers
{
    [ApiController]
    [Route("api/supervisor")]
    public class SupervisorController : Controller
    {

        private readonly ISupervisorService _supervisorService;
        public SupervisorController(ISupervisorService supervisorService)
        {
            _supervisorService = supervisorService;
        }
        [HttpPost("register-sale")]
        public async Task<IActionResult> RegisterTyreSale([FromBody] TyreSalesDTO tyreSalesDTO)
        {

            if (tyreSalesDTO == null)
            {
                return BadRequest("Invalid production data");
            }

            await _supervisorService.RegisterTyreSalesAsync(tyreSalesDTO);

            return CreatedAtAction(nameof(RegisterTyreSale), new { id = tyreSalesDTO.Id }, tyreSalesDTO);
        }
        [HttpGet("supervisor-history")]
        public async Task<IActionResult> GetTyreSalesHistory()
        {
            var record = await _supervisorService.GetAllSalesAsync();

            if(record == null || !record.Any())
            {
                return NotFound("No TyreSales Record found");
            }
            return Ok(record);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateProductionRecords([FromForm]ProductionDTO productionDTO)
        {
            bool result = await _supervisorService.UpdateProdutionRecords(productionDTO);
            if (result == false)
            {
                return BadRequest(new { Message = "Error while modifing record!" });
            }

            return Ok();

        }


       
    }
}
