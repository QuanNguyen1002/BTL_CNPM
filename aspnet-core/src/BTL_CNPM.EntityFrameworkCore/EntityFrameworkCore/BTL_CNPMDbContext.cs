using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BTL_CNPM.Authorization.Roles;
using BTL_CNPM.Authorization.Users;
using BTL_CNPM.MultiTenancy;

namespace BTL_CNPM.EntityFrameworkCore
{
    public class BTL_CNPMDbContext : AbpZeroDbContext<Tenant, Role, User, BTL_CNPMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BTL_CNPMDbContext(DbContextOptions<BTL_CNPMDbContext> options)
            : base(options)
        {
        }
    }
}
