using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class ProductionRecord
    {
        public int Id { get; set; }
        public string Action { get; set; }  // Description of the action performed
        public DateTime ActionTimestamp { get; set; }
        public int PerformedById { get; set; } // FK to User

        // Navigation properties
        public TyreProduction TyreProduction { get; set; }
        public User PerformedBy { get; set; }  // Relationship with User
    }
}
