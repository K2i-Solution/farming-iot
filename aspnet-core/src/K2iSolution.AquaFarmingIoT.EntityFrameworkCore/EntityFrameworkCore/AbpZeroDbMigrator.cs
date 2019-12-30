using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<AquaFarmingIoTDbContext>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IDbContextResolver dbContextResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                dbContextResolver)
        {
        }
    }
}
