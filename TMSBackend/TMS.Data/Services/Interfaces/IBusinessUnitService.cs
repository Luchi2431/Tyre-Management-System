using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.DTO;

namespace TMS.Data.Services.Interfaces
{
    public interface IBusinessUnitService
    {
        Task<IEnumerable<ProductionByDayDTO>> GetProductionByDayServiceAsync();
        Task<IEnumerable<ProductionByShiftDTO>> GetProductionByShiftServiceASync();
        Task<IEnumerable<ProductionByMachineDTO>> GetProductionByMachineServiceAsync();
        Task<IEnumerable<ProductionByOperatorDTO>> GetProductionByOperatorServiceASync();
        Task<IEnumerable<StockBalanceDTO>> GetStockBalanceServiceAsync();
    }
}
