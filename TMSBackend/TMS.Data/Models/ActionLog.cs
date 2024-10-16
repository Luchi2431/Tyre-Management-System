using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class ActionLog
    {
        public int LogID { get; set; } // Primary Key
        public int UserID { get; set; } // Foreign Key to User
        public User User { get; set; } // Navigation property
        public string ActionPerformed { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
