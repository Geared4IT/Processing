using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Processing.Authorization.Roles;
using Processing.Authorization.Users;
using Processing.MultiTenancy;

namespace Processing.EntityFrameworkCore
{
    public class ProcessingDbContext : AbpZeroDbContext<Tenant, Role, User, ProcessingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProcessingDbContext(DbContextOptions<ProcessingDbContext> options)
            : base(options)
        {
        }
    }
}
