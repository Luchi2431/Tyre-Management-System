using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class ProductionRecord
    {
        public int ProductionRecordID { get; set; } // Primary Key
        public int TyreID { get; set; } // Foreign Key to Tyre
        public Tyre Tyre { get; set; } // Navigation property

        public int OperatorID { get; set; } // Foreign Key to ProductionOperator
        public ProductionOperator Operator { get; set; } // Navigation property

        public DateTime ProductionDate { get; set; }
        public string ProductionShift { get; set; }
        public string MachineNumber { get; set; }
        public int QuantityProduced { get; set; }

        public string LoggedBy { get; set; }
        public DateTime LoggedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }

}
