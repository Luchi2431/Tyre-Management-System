using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class Tyre
    {
        public int TyreID { get; set; } // Primary Key
        public string TyreCode { get; set; }
        public string TyreName { get; set; }
        public string TyreType { get; set; }
        public int QuantityProduced { get; set; }
        public int QuantitySold { get; set; }
        public DateTime ProductionDate { get; set; }
        public string ProductionShift { get; set; }
        public string MachineNumber { get; set; }

        // Navigation properties
        public List<ProductionRecord> ProductionRecords { get; set; }
        public List<SaleRecord> SaleRecords { get; set; }
    }
}
