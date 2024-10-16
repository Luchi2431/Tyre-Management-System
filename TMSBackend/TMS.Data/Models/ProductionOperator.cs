using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class ProductionOperator
    {
        public int OperatorID { get; set; } // Primary Key
        public string OperatorName { get; set; }
        public string Shift { get; set; }

        // Navigation properties
        public List<ProductionRecord> ProductionRecords { get; set; } // One-to-many relationship
    }
}
