using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class DropdownOptions
    {
        public int OptionID { get; set; } // Primary Key
        public string OptionType { get; set; } // e.g., "Shift", "Machine"
        public string OptionValue { get; set; }
    }

}
