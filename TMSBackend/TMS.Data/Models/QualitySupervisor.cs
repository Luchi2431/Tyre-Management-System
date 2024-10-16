using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class QualitySupervisor
    {
        public int SupervisorID { get; set; } // Primary Key
        public string SupervisorName { get; set; }

        // Navigation properties
        public List<SaleRecord> SaleRecords { get; set; } // One-to-many relationship
    }

}
