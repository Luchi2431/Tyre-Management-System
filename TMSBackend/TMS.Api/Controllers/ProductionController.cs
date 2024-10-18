using Microsoft.AspNetCore.Mvc;
using TMS.Data.DTO;
using TMS.Data.Services.Interfaces;

namespace TMS.Api.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductionController : Controller
    {
        private readonly IProductionService _productionService;

        public ProductionController(IProductionService productionService)
        {
            _productionService = productionService;
        }

        [HttpPost("createRecord")]
        public async Task<IActionResult> CreateProductionRecord([FromBody] ProductionDTO productionDTO)
        {
            if (productionDTO == null)
            {
                return BadRequest("Invalid production data.");
            }

            await _productionService.CreateProductionAsync(productionDTO);

            return CreatedAtAction(nameof(CreateProductionRecord), new { id = productionDTO.Id }, productionDTO);
        }

        [HttpGet("history/{operatorId}")]
        public async Task<IActionResult> GetHistory(int operatorId)
        {
            var records = await _productionService.GetProductionRecordsByOpId(operatorId);

            if (records == null || !records.Any())
            {
                return NotFound("No production records found");
            }
            return Ok(records);


        }


    }
}
