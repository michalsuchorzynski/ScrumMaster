using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumMasterWebApplication.Context
{
    public class ScrumMasterDbContext :IdentityDbContext
    {
        public ScrumMasterDbContext(DbContextOptions<ScrumMasterDbContext> options) : base(options)
        {

        }
    }
}
