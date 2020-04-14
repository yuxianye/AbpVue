using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Solution.Authorization.Roles;
using Solution.Authorization.Users;
using Solution.MultiTenancy;

namespace Solution.EntityFrameworkCore
{
    public class SolutionDbContext : AbpZeroDbContext<Tenant, Role, User, SolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SolutionDbContext(DbContextOptions<SolutionDbContext> options)
            : base(options)
        {
        }
    }
}
