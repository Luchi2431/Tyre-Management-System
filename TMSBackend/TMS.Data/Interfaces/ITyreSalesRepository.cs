﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Models;

namespace TMS.Data.Interfaces
{
    public interface ITyreSalesRepository
    {
        Task addTyreSalesAsync(TyreSales tyreSales);
        Task<IEnumerable<TyreSales>> GetAllSales();
    }
}
