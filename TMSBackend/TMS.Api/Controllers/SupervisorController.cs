using Microsoft.AspNetCore.Mvc;
using TMS.Data.DTO;
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

       
    }
}
