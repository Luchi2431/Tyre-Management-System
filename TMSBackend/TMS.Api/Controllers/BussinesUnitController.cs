using Microsoft.AspNetCore.Mvc;
using TMS.Data.Services.Interfaces;

namespace TMS.Api.Controllers
{
    [ApiController]
    [Route("api/bussinesUnit")]
    public class BussinesUnitController : Controller
    {
        private readonly IBusinessUnitService _businessUnitService;

        public BussinesUnitController(IBusinessUnitService businessUnitService)
        {
            _businessUnitService = businessUnitService;
        }

        [HttpGet("production-reports-day")]
        public async Task<IActionResult> GetProductionByDay()
        {
            var result = await _businessUnitService.GetProductionByDayServiceAsync();
            return Ok(result);

        }
    }
}
