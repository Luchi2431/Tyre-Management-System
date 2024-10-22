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
    }
}
