﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.DTO;

namespace TMS.Data.Interfaces
{
    public interface ITyreProductionRepository
    {
        Task<IEnumerable<ProductionByDayDTO>> GetProductionByDayAsync();
    }
}
