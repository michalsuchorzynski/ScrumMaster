using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ScrumMasterDataContext
{
    public class ScrumMasterDbContext :IdentityDbContext
    {
        public ScrumMasterDbContext(DbContextOptions<ScrumMasterDbContext> options) : base(options)
        {

        }
    }
}
