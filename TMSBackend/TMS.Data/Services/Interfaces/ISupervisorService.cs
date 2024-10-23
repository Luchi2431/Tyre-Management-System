﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.DTO;
using TMS.Data.Models;

namespace TMS.Data.Services.Interfaces
{
    public interface ISupervisorService
    {
        Task RegisterTyreSalesAsync(TyreSalesDTO tyreSalesDTO);
        Task<IEnumerable<TyreSales>> GetAllSalesAsync();
    }
}