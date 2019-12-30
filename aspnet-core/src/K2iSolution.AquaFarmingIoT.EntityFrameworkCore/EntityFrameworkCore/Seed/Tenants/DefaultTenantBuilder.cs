using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;
using K2iSolution.AquaFarmingIoT.Editions;
using K2iSolution.AquaFarmingIoT.MultiTenancy;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly AquaFarmingIoTDbContext _context;

        public DefaultTenantBuilder(AquaFarmingIoTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            // Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
