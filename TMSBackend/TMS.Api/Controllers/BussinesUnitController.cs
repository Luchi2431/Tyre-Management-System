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

        [HttpGet("production-reports-shift")]
        public async Task<IActionResult> GetProductionByShift()
        {
            var result = await _businessUnitService.GetProductionByShiftServiceASync();
            return Ok(result);
        }
        [HttpGet("production-reports-machine")]
        public async Task<IActionResult> GetProductionByMachine()
        {
            var result = await _businessUnitService.GetProductionByMachineServiceAsync();
            return Ok(result);
        }
        [HttpGet("production-reports-operator")]
        public async Task<IActionResult> GetProductionByOperatorId()
        {
            var result = await _businessUnitService.GetProductionByOperatorServiceASync();
            return Ok(result);
        }
        [HttpGet("production-reports-stockbalance")]
        public async Task<IActionResult> GetProductionByStockBalance()
        {
            var result = await _businessUnitService.GetStockBalanceServiceAsync();
            return Ok(result);
        }
    }
}
