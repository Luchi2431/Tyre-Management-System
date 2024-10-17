using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Context;
using TMS.Data.Interfaces;

namespace TMS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TMSContext _db;

        public UserRepository(TMSContext db)
        {
            _db = db;
        }

    }
}
