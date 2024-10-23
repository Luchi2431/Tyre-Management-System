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
        private readonly IMapper _mapper;
        public SupervisorService(ITyreSalesRepository tyreSalesRepository, IMapper mapper)
        {
            _tyreSalesRepository = tyreSalesRepository;
            _mapper = mapper;
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
    }
}
