using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Context;
using TMS.Data.DTO;
using TMS.Data.Interfaces;

namespace TMS.Data.Repositories
{
    public class TyreProductionRepository : ITyreProductionRepository
    {
        private readonly TMSContext _db;
        public TyreProductionRepository(TMSContext db)
        {
            _db = db;          
        }


        public async Task<IEnumerable<ProductionByDayDTO>> GetProductionByDayAsync()
        {
            return await _db.ProductionByDay.FromSqlRaw("EXEC GetProductionByDay").ToListAsync();
        } 
    }
}
