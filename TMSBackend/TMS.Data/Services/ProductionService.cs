using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.DTO;
using TMS.Data.Interfaces;
using TMS.Data.Models;
using TMS.Data.Services.Interfaces;

namespace TMS.Data.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IProductionRecordRepository _productionRecordRepository;
        private readonly IMapper _mapper;

        public ProductionService(IProductionRecordRepository productionRecordRepository,IMapper mapper)
        {
            _productionRecordRepository = productionRecordRepository;
            _mapper = mapper;
   
        }


        public async Task CreateProductionAsync(ProductionDTO productionDTO)
        {
            var productionRecord = _mapper.Map<ProductionRecord>(productionDTO);

            productionRecord.ProductionDate = DateTime.UtcNow;
            productionRecord.PerformedById = productionDTO.PerformedById;

            await _productionRecordRepository.AddAsync(productionRecord);
        }

        public async Task<IEnumerable<ProductionRecord>> GetProductionRecordsByOpId(int operatorId)
        {
            return await _productionRecordRepository.GetByOperatorIdAsync(operatorId);
        }
    }
}
