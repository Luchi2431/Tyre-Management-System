using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDateTime { get; set; }

        //Navigation properties
        public TyreProduction TyreProduction { get; set; }
        public User User {  get; set; } 

    }
}
