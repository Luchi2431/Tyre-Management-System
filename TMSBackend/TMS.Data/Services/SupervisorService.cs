using AutoMapper;
using TMS.Data.DTO;
using TMS.Data.Interfaces;
using TMS.Data.Models;
using TMS.Data.Repositories;
using TMS.Data.Services.Interfaces;

namespace TMS.Data.Services
{
    public class SupervisorService : ISupervisorService
    {
        private readonly ITyreSalesRepository _tyreSalesRepository;
        private readonly IProductionRecordRepository _productionRecordRepository;
        private readonly IMapper _mapper;
        public SupervisorService(ITyreSalesRepository tyreSalesRepository, IMapper mapper,IProductionRecordRepository productionRecordRepository)
        {
            _tyreSalesRepository = tyreSalesRepository;
            _mapper = mapper;
            _productionRecordRepository = productionRecordRepository;
        }

        public async Task RegisterTyreSalesAsync(TyreSalesDTO tyreSalesDTO)
        {
            var tyreSalesRecord = _mapper.Map<TyreSales>(tyreSalesDTO);
            tyreSalesRecord.DateOfSale = DateTime.UtcNow;
            tyreSalesRecord.ReferenceProductionId = tyreSalesDTO.ReferenceProductionId;

            await _tyreSalesRepository.addTyreSalesAsync(tyreSalesRecord);
        }

        public async Task<IEnumerable<TyreSales>> GetAllSalesAsync()
        {
            return await _tyreSalesRepository.GetAllSales();
        }

        public async Task<bool> UpdateProdutionRecords(ProductionDTO productionDTO)
        {
            ProductionDTO newProductionDTO = _productionRecordRepository.UpdateRecord(productionDTO);
            if(newProductionDTO == null)
            {
                throw new Exception("Failed to update record");
            }
            return true;
        }
    }
}
