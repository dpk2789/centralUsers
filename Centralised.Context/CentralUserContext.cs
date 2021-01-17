using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Centralised.Context
{
    public class CentralUserContext : IdentityDbContext<AppUser>
    {
        public CentralUserContext(DbContextOptions<CentralUserContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
