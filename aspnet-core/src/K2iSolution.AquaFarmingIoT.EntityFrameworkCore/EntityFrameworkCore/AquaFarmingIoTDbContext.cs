using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using K2iSolution.AquaFarmingIoT.Authorization.Roles;
using K2iSolution.AquaFarmingIoT.Authorization.Users;
using K2iSolution.AquaFarmingIoT.MultiTenancy;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore
{
    public class AquaFarmingIoTDbContext : AbpZeroDbContext<Tenant, Role, User, AquaFarmingIoTDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AquaFarmingIoTDbContext(DbContextOptions<AquaFarmingIoTDbContext> options)
            : base(options)
        {
        }
    }
}
