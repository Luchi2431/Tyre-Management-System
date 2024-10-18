using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Context;
using TMS.Data.Interfaces;
using TMS.Data.Models;

namespace TMS.Data.Repositories
{
    public class ProductionRecordRepository : IProductionRecordRepository
    {
        private readonly TMSContext _db;

        public ProductionRecordRepository(TMSContext db)
        {
            _db = db;
        }

        public async Task AddAsync(ProductionRecord productionRecord)
        {
            await _db.ProductionRecords.AddAsync(productionRecord);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductionRecord>> GetByOperatorIdAsync(int operatorId)
        {
            return await _db.ProductionRecords.Where(pr => pr.PerformedById == operatorId).ToListAsync();

        }
    }
}
