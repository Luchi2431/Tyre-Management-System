using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class SaleRecord
    {
        public int SaleRecordID { get; set; } // Primary Key
        public int TyreID { get; set; } // Foreign Key to Tyre
        public Tyre Tyre { get; set; } // Navigation property

        public int SupervisorID { get; set; } // Foreign Key to QualitySupervisor
        public QualitySupervisor Supervisor { get; set; } // Navigation property

        public int QuantitySold { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime SaleDate { get; set; }
        public string Market { get; set; }
        public string PurchasingCompany { get; set; }
        public int ReferenceProductionOrderID { get; set; }

        public string LoggedBy { get; set; }
        public DateTime LoggedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }

}
