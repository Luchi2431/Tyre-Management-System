using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.DTO;
using TMS.Data.Interfaces;
using TMS.Data.Services.Interfaces;

namespace TMS.Data.Services
{
    public class BusinessUnitService : IBusinessUnitService
    {
        private readonly ITyreProductionRepository _tyreProductionRep;
        public BusinessUnitService(ITyreProductionRepository tyreProductionRep)
        {
            _tyreProductionRep = tyreProductionRep;
        }

        public async Task<IEnumerable<ProductionByDayDTO>> GetProductionByDayServiceAsync()
        {
            return await _tyreProductionRep.GetProductionByDayAsync();
        }

        public async Task<IEnumerable<ProductionByShiftDTO>> GetProductionByShiftServiceASync()
        {
            return await _tyreProductionRep.GetProductionByShiftAsync();
        }

        public async Task<IEnumerable<ProductionByMachineDTO>> GetProductionByMachineServiceAsync()
        {
            return await _tyreProductionRep.GetProductionByMachinesAsync();
        }

        public async Task<IEnumerable<ProductionByOperatorDTO>> GetProductionByOperatorServiceASync()
        {
            return await _tyreProductionRep.GetProductionByOperatorAsync();
        }

        public async Task<IEnumerable<StockBalanceDTO>> GetStockBalanceServiceAsync()
        {
            return await _tyreProductionRep.GetStockBalanceASync();
        }

    }
}
