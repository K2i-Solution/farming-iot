using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using K2iSolution.AquaFarmingIoT.Authorization.Users;
using K2iSolution.AquaFarmingIoT.Editions;

namespace K2iSolution.AquaFarmingIoT.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
