using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumMasterDataContext
{
    public class DesignTimeDbContextFactory
    {
        public ScrumMasterDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ScrumMaster;Trusted_Connection=True;MultipleActiveResultSets=true";

            var builder = new DbContextOptionsBuilder<ScrumMasterDbContext>();

            builder.UseSqlServer(connectionString);

            return new ScrumMasterDbContext(builder.Options);
        }
    }
}
