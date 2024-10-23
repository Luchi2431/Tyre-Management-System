using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Context;
using TMS.Data.DTO;
using TMS.Data.Interfaces;
using TMS.Data.Models;

namespace TMS.Data.Repositories
{
    public class ProductionRecordRepository : IProductionRecordRepository
    {
        private readonly TMSContext _db;
        private readonly IMapper _mapper;

        public ProductionRecordRepository(TMSContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
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

        public ProductionDTO UpdateRecord(ProductionDTO productionDTO)
        {
            ProductionRecord productionRecord = _mapper.Map<ProductionRecord>(productionDTO);
            _db.ProductionRecords.Update(productionRecord);
            _db.SaveChanges();

            return _mapper.Map<ProductionDTO>(productionRecord);
        }
    }
}
