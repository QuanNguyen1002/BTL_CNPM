using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BTL_CNPM.Authorization.Roles;
using BTL_CNPM.Authorization.Users;
using BTL_CNPM.MultiTenancy;
using BTL_CNPM.Entity;

namespace BTL_CNPM.EntityFrameworkCore
{
    public class BTL_CNPMDbContext : AbpZeroDbContext<Tenant, Role, User, BTL_CNPMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamRole> TeamRoles { get; set; }
        public BTL_CNPMDbContext(DbContextOptions<BTL_CNPMDbContext> options)
            : base(options)
        {
        }
    }
}
