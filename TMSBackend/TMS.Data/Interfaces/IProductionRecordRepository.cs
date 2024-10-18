using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Models;

namespace TMS.Data.Interfaces
{
    public interface IProductionRecordRepository
    {
        Task AddAsync(ProductionRecord productionRecord);
        Task<IEnumerable<ProductionRecord>> GetByOperatorIdAsync(int operatorId);
    }
}
