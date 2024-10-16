using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Enums;

namespace TMS.Data.Models
{
    public class User
    {
        public int UserID { get; set; } // Primary Key
        public string Username { get; set; }
        public string UserRole { get; set; } // Enum: "ProductionOperator", "QualitySupervisor", "BusinessUnitLeader"

        // Navigation properties
        public List<ActionLog> ActionLogs { get; set; }
    }

}
